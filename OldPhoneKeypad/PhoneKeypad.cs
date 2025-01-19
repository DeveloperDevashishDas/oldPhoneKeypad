using System;
using System.Collections.Generic;
using System.Text;

namespace OldPhoneKeypad
{
    public class PhoneKeypad
    {
            public static string OldPhonePad(string input)
            {
                StringBuilder appendString = new StringBuilder();
                StringBuilder addString = new StringBuilder();

            # region 
            /*Dictionary with Key Value pair.Numbers as key and alphabets as its values*/
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                {"2", "A"},{"22", "B"},{"222", "C" },
                {"3", "D" },{"33", "E" },{"333", "F" },
                {"4", "G"},{"44", "H" },{"444", "I" },
                {"5", "J" },{"55", "K" },{"555", "L" },
                {"6", "M" },{"66", "N" },{"666", "O" },
                {"7", "P" },{ "77", "Q"},{ "777", "R"},{"7777", "S" },
                {"8", "T" },{"88", "U" },{"888", "V" },
                {"9", "W" },{"99", "X" },{"999", "Y" },{"9999", "Z" },{ "0", "" }
              };
            #endregion

            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (appendString.Length == 0 || input[i] == input[i - 1])
                    {
                        appendString.Append(input[i]);
                    }
                    else
                    {
                        if (!char.IsWhiteSpace(input[i]))
                        {
                            if (input[i] == '*')
                            {
                                appendString.Remove(appendString.Length - 1, 1);
                            }
                            else
                            {
                                addString.Append(dict[appendString.ToString()]);
                                if (input[i] == '#')
                                    break;
                                appendString = new StringBuilder();
                                appendString.Append(input[i]);
                            }
                        }
                        else
                        {
                            addString.Append(dict[appendString.ToString()]);
                            appendString = new StringBuilder();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

                return addString.ToString();
            }
            static void Main()
            {
            
            PhoneKeypad obj = new PhoneKeypad();

            /*Accepting Input from the users
            Console.WriteLine("Enter Numbers with # at the end");
            string userInput = Console.ReadLine();
            Console.Write("{0} is {1}", userInput, PhoneKeypad.OldPhonePad(userInput));
            /*

            /*Examples as mentioned in the requirement */
            Console.WriteLine("33# {0}", PhoneKeypad.OldPhonePad("33#"));
            Console.WriteLine("227*# {0}", PhoneKeypad.OldPhonePad("227*#"));
            Console.WriteLine("222 2 22# {0}", PhoneKeypad.OldPhonePad("222 2 22#"));
            Console.WriteLine("4433555 555666# {0}", PhoneKeypad.OldPhonePad("4433555 555666#"));
            Console.WriteLine("8 88777444666*664# {0}", PhoneKeypad.OldPhonePad("8 88777444666*664#"));
            Console.Read();
            }
    }
    }
