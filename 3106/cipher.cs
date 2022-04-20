using System;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

namespace _3106.Resources
{
    internal class cipher
    {
        public static cipher ci = new cipher();

        public static char[,] alphabetBoard = new char[5, 5];
        public static bool oddFlag = false; //글자수 출력
        public String zCheck;

        public String encryption_trim;
        public String encryption;
        public String decryption;
        public String blankCheck;

        public static string[, ] alpha = new string[5, 5];

        public void Encryption(String ciphertext, String plaintext)
        {
            zCheck = "";
            blankCheck = "";

            setBoard(ciphertext);                          //암호화에 쓰일 암호판 세팅

            for (int i = 0; i < plaintext.Length; i++)
            {
                if (plaintext[i] == ' ') //공백제거
                {
                    plaintext = plaintext.Substring(0, i) + plaintext.Substring(i + 1, plaintext.Length - (i + 1));
                    Console.WriteLine(plaintext.Substring(0, i) + plaintext.Substring(i + 1, plaintext.Length - (i + 1)));
                    blankCheck += 10;
                }
                else
                {
                    blankCheck += 0;
                }
                if (plaintext[i] == 'z') //z를 q로 바꿔줘서 처리함.
                {
                    plaintext = plaintext.Substring(0, i) + 'q' + plaintext.Substring(i + 1, plaintext.Length - (i + 1));
                    zCheck += 1;
                }
                else
                {
                    zCheck += 0;
                }
            }

            // 암호화
            encryption = strEncryption(ciphertext, plaintext);

            // Console.WriteLine("암호화된 문자열 : " + encryption);

            encryption_trim = encryption;

            for (int i = 0; i < encryption.Length; i++)
            {
                if (encryption[i] == ' ') //공백제거
                    encryption = encryption.Substring(0, i) + encryption.Substring(i + 1, encryption.Length - (i + 1));
            }

        }

        public void Decryption(String ciphertext, String encryptiontext)
        {
            setBoard(ciphertext);                          //암호화에 쓰일 암호판 세팅

            for (int i = 0; i < encryptiontext.Length; i++)
            {
                if (encryptiontext[i] == ' ') //공백제거
                    encryptiontext = encryptiontext.Substring(0, i) + encryptiontext.Substring(i + 1, encryptiontext.Length - (i + 1));
            }

            decryption = strDecryption(ciphertext, encryptiontext, zCheck);

            for (int i = 0; i < blankCheck.Length; i++)
            {
                if (blankCheck[i] == '1')
                {
                    decryption = decryption.Substring(0, i) + " " + decryption.Substring(i, decryption.Length - i);
                }
            }

            Console.WriteLine("복호화된 문자열 : " + decryption);

        }

        private static String strDecryption(String key, String str, String zCheck)
        {
            List<char[]> playFair = new List<char[]>(); //바꾸기 전 쌍자암호를 저장할 곳
            List<char[]> decPlayFair = new List<char[]>(); //바꾼 후의 쌍자암호 저장할 곳
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0; //쌍자 암호 두 글자의 각각의 행,열 값
            String decStr = "";

            for (int i = 0; i < str.Length; i += 2)
            {
                char[] tmpArr = new char[2];
                tmpArr[0] = str[i];
                tmpArr[1] = str[i + 1];
                playFair.Add(tmpArr);
            }

            for (int i = 0; i < playFair.Count; i++)
            {

                char[] tmpArr = new char[2];
                for (int j = 0; j < alphabetBoard.GetLength(0); j++)
                {
                    for (int k = 0; k < alphabetBoard.GetLength(0); k++)
                    {
                        if (alphabetBoard[j, k] == playFair[i][0])
                        {
                            x1 = j;
                            y1 = k;
                        }
                        if (alphabetBoard[j, k] == playFair[i][1])
                        {
                            x2 = j;
                            y2 = k;
                        }
                    }
                }

                if (x1 == x2) //행이 같은 경우 각각 바로 아래열 대입
                {
                    tmpArr[0] = alphabetBoard[x1, (y1 + 4) % 5];
                    tmpArr[1] = alphabetBoard[x2, (y2 + 4) % 5];
                }
                else if (y1 == y2) //열이 같은 경우 각각 바로 옆 열 대입
                {
                    tmpArr[0] = alphabetBoard[(x1 + 4) % 5, y1];
                    tmpArr[1] = alphabetBoard[(x2 + 4) % 5, y2];
                }
                else //행, 열 다른경우 각자 대각선에 있는 곳.
                {
                    tmpArr[0] = alphabetBoard[x2, y1];
                    tmpArr[1] = alphabetBoard[x1, y2];
                }

                decPlayFair.Add(tmpArr);

            }

            for (int i = 0; i < decPlayFair.Count; i++) //중복 문자열 돌려놓음
            {
                if (i != decPlayFair.Count - 1 && decPlayFair[i][1] == 'x'
                        && decPlayFair[i][0] == decPlayFair[i + 1][0])
                {
                    decStr += decPlayFair[i][0];
                }
                else
                {
                    decStr += decPlayFair[i][0] + "" + decPlayFair[i][1];
                }
            }



            for (int i = 0; i < zCheck.Length; i++)//z위치 찾아서 q로 돌려놓음
            {
                if (zCheck[i] == '1')
                    decStr = decStr.Substring(0, i) + 'z' + decStr.Substring(i + 1, decStr.Length);

            }



            if (oddFlag) decStr = decStr.Substring(0, decStr.Length - 1);

            /*
				//띄어쓰기
			for(int i = 0 ; i < decStr.length(); i++)
			{
				if(i%2==lengthOddFlag){
					decStr = decStr.substring(0, i+1)+" "+decStr.substring(i+1, decStr.length());
					i++;
					lengthOddFlag = ++lengthOddFlag %2;
				}
			}
			*/
            return decStr;
        }

        private static String strEncryption(String key, String str)
        {
            List<char[]> playFair = new List<char[]>();
            List<char[]> encPlayFair = new List<char[]>();
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            String encStr = "";

            for (int i = 0; i < str.Length; i += 2) // arraylist 세팅
            {
                char[] tmpArr = new char[2];
                tmpArr[0] = str[i];
                try
                {
                    if (str[i] == str[i + 1]) //글이 반복되면 x추가
                    {
                        tmpArr[1] = 'x';
                        i--;
                    }
                    else
                    {
                        tmpArr[1] = str[i + 1];
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    tmpArr[1] = 'x';
                    oddFlag = true;
                }
                playFair.Add(tmpArr);
            }

            for (int i = 0; i < playFair.Count; i++)
            {
                Console.WriteLine(playFair[i][0] + " " + playFair[i][1] + " ");
            }

            for (int i = 0; i < playFair.Count; i++)
            {
                char[] tmpArr = new char[2];
                for (int j = 0; j < alphabetBoard.GetLength(0); j++) //쌍자암호의 각각 위치체크
                {
                    for (int k = 0; k < alphabetBoard.GetLength(0); k++)
                    {
                        if (alphabetBoard[j, k] == playFair[i][0])
                        {
                            x1 = j;
                            y1 = k;
                        }
                        if (alphabetBoard[j, k] == playFair[i][1])
                        {
                            x2 = j;
                            y2 = k;
                        }
                    }
                }
                if (x1 == x2) //행이 같은경우
                {
                    tmpArr[0] = alphabetBoard[x1, (y1 + 1) % 5];
                    tmpArr[1] = alphabetBoard[x2, (y2 + 1) % 5];
                }
                else if (y1 == y2) //열이 같은 경우
                {
                    tmpArr[0] = alphabetBoard[(x1 + 1) % 5, y1];
                    tmpArr[1] = alphabetBoard[(x2 + 1) % 5, y2];
                }
                else //행, 열 모두 다른경우
                {
                    tmpArr[0] = alphabetBoard[x2, y1];
                    tmpArr[1] = alphabetBoard[x1, y2];
                }

                encPlayFair.Add(tmpArr);

            }

            for (int i = 0; i < encPlayFair.Count; i++)
            {
                encStr += encPlayFair[i][0] + "" + encPlayFair[i][1] + " ";
            }

            return encStr;
        }

        private static void setBoard(String key)
        {
            String keyForSet = "";                  // 중복된 문자가 제거된 문자열을 저장할 문자열.
            bool duplicationFlag = false;        // 문자 중복을 체크하기 위한 flag 변수.
            int keyLengthCount = 0;                 // alphabetBoard에 keyForSet을 넣기 위한 count변수.

            key += "abcdefghijklmnopqrstuvwxyz";    // 키에 모든 알파벳을 추가.


            // 중복처리
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < keyForSet.Length; j++)
                {
                    if (key[i] == keyForSet[j])
                    {
                        duplicationFlag = true;
                        break;
                    }
                }
                if (!(duplicationFlag)) keyForSet += key[i];
                duplicationFlag = false;
            }
            //배열에 대입
            for (int i = 0; i < alphabetBoard.GetLength(0); i++)
            {
                for (int j = 0; j < alphabetBoard.GetLength(0); j++)
                {
                    alphabetBoard[i, j] = keyForSet[keyLengthCount++];
                }
            }
            // 출력용
            for (int i = 0; i < alphabetBoard.GetLength(0); i++)
            {
                for (int j = 0; j < alphabetBoard.GetLength(0); j++)
                {
                    Console.Write(alphabetBoard[i, j] + "-");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < alpha.GetLength(0); i++)
            {
                for (int j = 0; j < alpha.GetLength(0); j++)
                {
                    alpha[i, j] = alphabetBoard[i, j].ToString();
                    if (alphabetBoard[i, j] == 'q')
                    {
                        alpha[i, j] += "/z";

                    }
                }
            }
        }

    }
}