using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;  // to play a WindowsMediaFolder file 

namespace Credit_Card_Validation
{
    public partial class Form1 : Form
    {        
        
        public Form1()
        {
            InitializeComponent();
        }

        // needs to be accessed within 3 methods to increase efficiency 
        bool isCardValid = true;

        // used to control music files within 2 methods (therefore it is local to class)
        WindowsMediaPlayer soundPlayer = new WindowsMediaPlayer(); 

        // this method/event handles methods which type out the type of card and validity of number
        private void IsValidButton_Click(object sender, EventArgs e)
        {
            IsCardValidTextbox.Text = checkCardType(InputNumberTextbox.Text);
            soundPlayer.controls.stop(); 

            // isSumValid Method only runs if isCardValid bool is true. Thus, this bool increases speed and efficiency. 
            if (isCardValid == true)
            {
                if (isSumValid(InputNumberTextbox.Text) == false)
                {
                    IsCardValidTextbox.Text = "Invalid Card Type"; 
                }
                addMusicAndPictures(); 
            }
            else
            {
                addMusicAndPictures();
                isCardValid = true;             
            } 
        }

        // this method/event is used to generate a valid number depending on the card type chosen
        private void GenerateNumberButton_Click(object sender, EventArgs e)
        {
            
            if (VisaCard.Checked)
                OutputNumberTextbox.Text = generateCardNumber(16, "4", 1); 

            else if (MasterCard.Checked)
            {                
                Random rnd = new Random();

                // used to generate random prefixes for MasterCard
                int randomPrefix = rnd.Next(51, 56);
                OutputNumberTextbox.Text = generateCardNumber(16, randomPrefix.ToString(), 2);
            }

            else if (DinerClub.Checked)
                OutputNumberTextbox.Text = generateCardNumber(14, "36", 2);

            else if (AmericanExpress.Checked)
            {
                Random rnd = new Random();

                // used to generate random prefixes for MasterCard
                int randomPrefix = rnd.Next(1, 3);

                if (randomPrefix == 1)
                    randomPrefix = 34;
                else if (randomPrefix == 2)
                    randomPrefix = 37; 

                OutputNumberTextbox.Text = generateCardNumber(15, randomPrefix.ToString(), 2); 
            }
                
            else if (Discover.Checked)
                OutputNumberTextbox.Text = generateCardNumber(16, "6011", 4);

            else
                OutputNumberTextbox.Text = "Please Select Card Type";

        } 

        // this method checks the card type of the number entered 
        private string checkCardType(string number)
        {          
            for (int a = 0; a<= number.Length - 1; a++)
            {
               int num = 0;

                // returns "Enter Numbers Only" if the number entered contains non-numerical characters (if tryparse method is not able to convert character into string)
                if (int.TryParse(number.Substring(a,1),out num) == false )
                {
                    isCardValid = false; 
                    return "Enter Numbers Only"; 
                }               
            }
            
            number = number.Replace(" ", "");  

            if (number == "")
            {
                isCardValid = false; 
                return "Please Enter Card Number";                
            }  

            if (number.Length == 16)
            {
                if (number.Substring(0, 1) == Convert.ToString(4))
                {
                    return "Visa Card";
                }

                else if (Convert.ToInt32(number.Substring(0, 2)) >= 51 && Convert.ToInt32(number.Substring(0, 2)) <= 55)
                {
                    return "Master Card";
                }
                else if (number.Substring(0, 4) == Convert.ToString(6011))
                {
                    return "Discover";
                }
                else
                {                                                
                    return "Invalid Card Type";
                }
            }

            else if (number.Length == 15 && (number.Substring(0, 2) == Convert.ToString(34) || number.Substring(0, 2) == Convert.ToString(37)))
            {
                return "American Express";
            }

            else if (number.Length == 14 && number.Substring(0, 2) == Convert.ToString(36))
            {
                return "Diners Club";
            }
            else
            {
                isCardValid = false; 
                return "Invalid Card Type"; 
            }
                       
        }

        // this method checks whether the sum is valid
        private bool isSumValid (string number)
        {
            int checksum = 0;

            number = number.Replace(" ", "");

            // adds up all odd placed numbers (in reversed order) 
            for (int i = number.Length - 1; i >= 0; i -= 2)
            {
                checksum += Convert.ToInt32(number.Substring(i, 1));
            }

            // adds up all even placed numbers, in reversed order (using luhn algorithm) 
            for (int i = number.Length - 2; i >= 0; i -= 2)
            {               
                if (Convert.ToInt32(number.Substring(i, 1)) >= 5)
                {
                    checksum += Convert.ToInt32(number.Substring(i, 1)) * 2 - 10 + 1;
                 
                }
                else 
                {
                    checksum += Convert.ToInt32(number.Substring(i, 1)) * 2;
                }
            }

            if (checksum % 10 == 0 && checksum > 0)
            {              
                return true;
            }
            else
            {
                isCardValid = false;         
                return false;
            }
                
        }

        // this method generates a valid number 
        private string generateCardNumber (int length, string prefix, int prefixLength)
        {

            string generatedNumber = prefix;
            int checksum2 = 0;   
            Random rnd = new Random();

            // concatinates random numbers until the lenth of generatedNumber is the length of the card chosen minus one. The last digit is caculated later on.  
            for (int a = prefixLength; a <= length - 2; a++)
            {
                int randomNum = rnd.Next(0, 10);
                generatedNumber += randomNum.ToString(); 
            }

            // sums up the odd digits using the luhn algorithm  
            for (int b = length - 3; b >= 0; b -= 2 )
            {
                checksum2 += Convert.ToInt32(generatedNumber.Substring(b, 1)); 
            }
        
            // sums up the even digits using the luhn algorithm
            for (int c = length - 2; c >= 0; c -= 2)
            {
                if (Convert.ToInt32(generatedNumber.Substring(c, 1)) >= 5)
                    checksum2 += Convert.ToInt32(generatedNumber.Substring(c, 1)) * 2 - 9;
                else
                    checksum2 += Convert.ToInt32(generatedNumber.Substring(c, 1)) * 2;
            }
            // finds out what the last digit should be
            if (checksum2 % 10 == 0)
            {
                generatedNumber += 0.ToString(); 
                return generatedNumber;
            }
            else
            {
                generatedNumber += (10 - (checksum2 % 10)).ToString();
            } 
           

            return generatedNumber; 
        }

        // controls music and pictures depending on validity of card
        private void addMusicAndPictures ()
        {           

            if (isCardValid == false)
            {              
                soundPlayer.URL = ("PoliceSiren.mp3");
                soundPlayer.controls.play();
                RobberPic.Visible = true;
                BillGatesPic.Visible = false;                       
            }

            else 
            {
                soundPlayer.URL = ("MoneyMoney.mp3");
                soundPlayer.controls.play();
                RobberPic.Visible = false;
                BillGatesPic.Visible = true;                                        
            }
                                   
        }
     
    }
}