using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RudDmytro_GlobalLogic_test_
{
    class Program
    {

        public static List<string> X_1_19_F = new List<string>();
        public static List<string> X_1_19_M = new List<string>();
        public static List<string> XX_10_90 = new List<string>();
        public static List<string> XXX_100_900 = new List<string>();
        public static List<string> XXXnames_1 = new List<string>();
        public static List<string> XXXnames_2_4 = new List<string>();
        public static List<string> XXXnames_5_9 = new List<string>();
        public static List<string> XXXnames_1000plus_1 = new List<string>();
        public static List<string> XXXnames_1000plus_2_4 = new List<string>();
        public static List<string> XXXnames_1000plus_5_9 = new List<string>();
        public static string Unbelievable = "";



        static void Main(string[] args)
        {
        

            for (; ; ) {
                Console.WriteLine("Chose language: \n1-UA\n2-UK\n");
                string language = Console.ReadLine();
                Console.WriteLine("\nEnter \"e\" for changing language\nEnter number");
                if (language == "1")
                {
                     X_1_19_F = new List<string>() { "", "однa ", "дві ", "три ", "чотири ", "п*ять ", "шість ", "сім ", "вісім ", "дев*ять ", "десять ", "одинадцять ", "дванадцять ", "тринадцять ", "чотирнадцять ", "п*ятнадцять ", "шістнадцять ", "сімнадцять ", "вісімнадцять ", "дев*ятнадцять " };
                     X_1_19_M = new List<string>() { "", "один ", "два ", "три ", "чотири ", "п*ять ", "шість ", "сім ", "вісім ", "дев*ять ", "десять ", "одинадцять ", "дванадцять ", "тринадцять ", "чотирнадцять ", "п*ятнадцять ", "шістнадцять ", "сімнадцять ", "вісімнадцять ", "дев*ятнадцять " };
                     XX_10_90 = new List<string>() { "", "десять ", "двадцять ", "тридцять ", "сорок ", "п*ядесят ", "шістдесят ", "сімдесят ", "вісімдесят ", "дев*яносто " };
                     XXX_100_900 = new List<string>() { "", "сто ", "двісті ", "триста ", "чотириста ", "п*ятсот ", "шістсот ", "сімсот ", "вісімсот ", "дев*ятсот " };
                     XXXnames_1 = new List<string>() { "копійочка ", "гривня " };
                     XXXnames_2_4 = new List<string>() { "копійки ", "гривні " };
                     XXXnames_5_9 = new List<string>() { "монєт ", "гривень " };
                     XXXnames_1000plus_1 = new List<string>() { "", "тисяча ", "мільйон ", "мільярд " };
                     XXXnames_1000plus_2_4 = new List<string>() { "", "тисячі ", "мільйони ", "мільярди " };
                     XXXnames_1000plus_5_9 = new List<string>() { "", "тисяч ", "мільйонів ", "мільярдів " };
                    Unbelievable = "Такі гроші тільки в Джеффа Безоса!";
                }
                if (language == "2")
                {
                    X_1_19_F = new List<string>() { "", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine ", "ten ", "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ", "eighteen ", "ninrteen " };
                    X_1_19_M = new List<string>() { "", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine ", "ten ", "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ", "eighteen ", "ninrteen " };
                    XX_10_90 = new List<string>() { "", "ten ", "twenty ", "thirty ", "fourty ", "fifty ", "sixty ", "seventy ", "einghty ", "ninety " };
                    XXX_100_900 = new List<string>() { "", "one hundred ", "two hundred ", "three hundred ", "four hundred ", "five hundred ", "six hundred ", "seven hundred ", "eight hundred ", "nine hundred " };
                    XXXnames_1 = new List<string>() { "cent ", "dolar " };
                    XXXnames_2_4 = new List<string>() { "cent ", "dolars " };
                    XXXnames_5_9 = new List<string>() { "cent ", "dolars " };
                    XXXnames_1000plus_1 = new List<string>() { "", "thousand ", "million ", "billion " };
                    XXXnames_1000plus_2_4 = new List<string>() { "", "thousand ", "million ", "billion " };
                    XXXnames_1000plus_5_9 = new List<string>() { "", "thousand ", "million ", "billion " };
                    Unbelievable = "You're UNBELIEVABLE rich, bro";
                } if(language=="1"||language=="2")
                for (; ; )
                {
                  
                    var entryText = Console.ReadLine();
                    if (entryText == "e") break;
                    string stringUA = null;
                    string stringUK = null;


                    if (entryText.Length <= 13)
                    {

                        try
                        {
                            stringUK = getStringUK(entryText);
                            Console.WriteLine(stringUK);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message.ToString());
                        }

                    }
                    else { Console.WriteLine(Unbelievable); }

                }

            }
        }

        public static string parceString(string entryText)
        {
            string beforDot=null;
            string afterDot=null;
            string temp = "";

            var dividedByDot = entryText.Split(".");
          
            if (dividedByDot[0].Length % 3 == 1) beforDot = "00" + dividedByDot[0];
            if (dividedByDot[0].Length % 3 == 2) beforDot = "0" + dividedByDot[0];
            if (dividedByDot[0].Length % 3 == 0) beforDot = dividedByDot[0];
            if (dividedByDot.Length > 1) { 
                if (dividedByDot[1].Length == 2) afterDot = "."+ dividedByDot[1];
                if (dividedByDot[1].Length == 1) afterDot = "."+ dividedByDot[1]+ "0";
                if (dividedByDot[1].Length >2) afterDot = "."+ dividedByDot[1].Substring(0,2);
            }

            for (int i = beforDot.Length-1; i >=0; i--)
            {
                temp =  beforDot[i]+ temp;
                if (i % 3 == 0&&i!=0) temp = "*"+ temp ;
            }


            return temp+afterDot;
        }

        public static string getStringUA(string entryText)
        {
            string result = null;
           




            return result;
        }
        public static string getStringUK(string entryText)
        {
            string temp = null;
            string leftString = "";
            string rightString = "";
            string result = null;
            string str = parceString(entryText);

            var p = str.Split(".");
            string leftPart = p[0];

            var threeplets = leftPart.Split("*");
            for (int i = threeplets.Length - 1; i >= 0; i--)
            {
                temp = "";


                //hundreds XXX
                temp = XXX_100_900[int.Parse(threeplets[i][0].ToString())];

                //XX and X
                if (threeplets[i][1] == '1')
                {
                    if (i == threeplets.Length - 1)
                        temp = temp + X_1_19_F[int.Parse(threeplets[i][2].ToString()) + 10];
                    else
                        temp = temp + X_1_19_M[int.Parse(threeplets[i][2].ToString()) + 10];
                }
                else
                {

                    if (i == threeplets.Length - 2|| i == threeplets.Length - 1)
                    {
                        if (threeplets[i][1] != '0') temp = temp + XX_10_90[int.Parse(threeplets[i][1].ToString())];
                        
                        temp = temp + X_1_19_F[int.Parse(threeplets[i][2].ToString())];
                    }
                    else
                    {
                        if (threeplets[i][1] != '0') temp = temp + XX_10_90[int.Parse(threeplets[i][1].ToString())];
                       temp = temp + X_1_19_M[int.Parse(threeplets[i][2].ToString())];
                    }
                }
                //for name of 10^3 XXX
                if (threeplets[i][0] != '0' || threeplets[i][1] != '0' || threeplets[i][2] != '0')
                {
                    if (threeplets[i][2] == '0') leftString = temp + XXXnames_1000plus_5_9[threeplets.Length - 1 - i] + leftString;
                    if (threeplets[i][2] == '1') if (threeplets[i][1] != '1') leftString = temp + XXXnames_1000plus_1[threeplets.Length - 1 - i] + leftString;
                        else leftString = temp + XXXnames_1000plus_5_9[threeplets.Length - 1 - i] + leftString;
                    if (threeplets[i][2] == '2' ||
                       threeplets[i][2] == '3' ||
                        threeplets[i][2] == '4')
                        if (threeplets[i][1] != '1') leftString = temp + XXXnames_1000plus_2_4[threeplets.Length - 1 - i] + leftString;
                        else leftString = temp + XXXnames_1000plus_5_9[threeplets.Length - 1 - i] + leftString;
                    if (int.Parse(threeplets[i][2].ToString()) > 4) leftString = temp + XXXnames_1000plus_5_9[threeplets.Length - 1 - i] + leftString;
                }
            }
            //for currency
                if (threeplets[threeplets.Length - 1][2] == '0') leftString = leftString + XXXnames_5_9[1];
                if (threeplets[threeplets.Length - 1][2] == '1')
                    if (threeplets[threeplets.Length - 1][1] != '1') leftString = leftString + XXXnames_1[1];
                    else leftString = leftString + XXXnames_5_9[1];
                if (threeplets[threeplets.Length - 1][2] == '2' ||
                    threeplets[threeplets.Length - 1][2] == '3' ||
                    threeplets[threeplets.Length - 1][2] == '4')
                    if (threeplets[threeplets.Length - 1][1] != '1') leftString = leftString + XXXnames_2_4[1];
                    else leftString = leftString + XXXnames_5_9[1];
                if (int.Parse(threeplets[threeplets.Length - 1][2].ToString()) > 4) leftString = leftString + XXXnames_5_9[1];

            string rightPart = null;
            if (p.Length > 1)
            {
                rightPart = p[1];
                
                   
                    if (rightPart[0] == '1')
                    {
                       
                        rightString = rightString + X_1_19_F[int.Parse(rightPart[1].ToString()) + 10];
                    }
                    else {
                        if (rightPart[0] != '0')
                            rightString = rightString + XX_10_90[int.Parse(rightPart[0].ToString())];
                       if(rightPart[1]!='0') rightString = rightString + X_1_19_F[int.Parse(rightPart[1].ToString())];
                    }

                //+cent
                if (rightPart[1] == '0') rightString = rightString + XXXnames_5_9[0];
                if (rightPart[1] == '1') if(rightPart[0] != '1') rightString = rightString + XXXnames_1[0];
                else rightString = rightString + XXXnames_5_9[0];
                if (rightPart[1] == '2'||
                    rightPart[1] == '3'||
                    rightPart[1] == '4' ) if(rightPart[0] != '1') rightString = rightString + XXXnames_2_4[0];
                else rightString = rightString + XXXnames_5_9[0];
                if (int.Parse(rightPart[1].ToString()) >4) rightString = rightString + XXXnames_5_9[0];
            }





            result = leftString + rightString;
            return result;
        }

       

    }
}
