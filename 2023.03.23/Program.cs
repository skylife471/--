using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._03._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int max = 3; //const 는 상수로 사용함.
            int[] score = new int[10];
            string[] name = new string[10];
            int count = 0;
            
            for (; ; )
            {
                Console.WriteLine("1.학생정보 추가");
                Console.WriteLine("2.학생정보 수정");// 몇번 학생을 수정해야하는지 정해야함 
                Console.WriteLine("3.학생정보 삭제");//3번째 학생 없애고 카운트 -- 원하는 학생을 삭제할 수 있게 하는 추가 로직으로 바꾸는게 과제이다, 만약 몇번을 누르면 삭제가 된다.
                Console.WriteLine("4.학생정보 목록보기");
                Console.WriteLine("5.종료"); 
                Console.Write("입력 : ");

                var input = int.Parse(Console.ReadLine());

                switch(input)
                {
                    case 1:
                        if (count < 3)
                        {
                            Console.WriteLine();
                            Console.Write("학생이름 : ");
                            var input2 = Console.ReadLine(); //name 은 지역변수 배열로 선언이 되어있습니다. name 이 어떤걸 말하는지 오류
                            name[count] = input2;

                            Console.Write("성적 : ");
                            var input3 = int.Parse(Console.ReadLine());
                            score[count] = input3;

                            count++;
                        }
                        else
                        {
                            Console.WriteLine("더이상 학생정보를 입력할 수 없습니다");
                        }
                        break;
                    case 2:
                        Console.WriteLine("몇번 학생을 수정 하시겠습니까?");
                        var input5 = int.Parse(Console.ReadLine());
                        if (input5 == 1)
                        {
                            Console.Write("학생이름 : ");
                            var input6 = Console.ReadLine(); 
                            name[0] = input6;

                            Console.Write("성적 : ");
                            var input7 = int.Parse(Console.ReadLine());
                            score[0] = input7;
                        }
                        if (input5 == 2)
                        {
                            Console.Write("학생이름 : ");
                            var input8 = Console.ReadLine();
                            name[1] = input8;

                            Console.Write("성적 : ");
                            var input9 = int.Parse(Console.ReadLine());
                            score[1] = input9;
                        }
                        if (input5 == 1)
                        {
                            Console.Write("학생이름 : ");
                            var input10 = Console.ReadLine();
                            name[2] = input10;

                            Console.Write("성적 : ");
                            var input11 = int.Parse(Console.ReadLine());
                            score[2] = input11;
                        }
                        break;
                    case 3:
                        Console.WriteLine("몇번 학생을 삭제하겠습니까?");
                        var input4 = int.Parse(Console.ReadLine());
                        if (input4 == 1)
                        {
                            for( int j =0;j<2; j++)
                            {
                                name[j] = name[j + 1];
                                score[j] = score[j + 1];
                            }
                            name[2] = name[4];
                            score[2] = score[4];
                            count--;
                        }
                        if (input4 == 2)
                        {
                            int h = 0;
                            name[1] = name[4];
                            score[1] = score[4];
                            name[h+1] = name[h + 2];
                            score[h+1] = score[h + 2];
                            name[2] = name[5];
                            score[2] = score[5];

                            count--;
                        }
                        if (input4 == 3)
                        {
                            score[2] = score[3];
                            name[2] = name[3];
                            count--;
                        }
                        break;
                    case 4:
                        if (count == 0)
                            Console.WriteLine("학생수를 추가하시오");
                        else if (count == 1)
                        {
                            for (int r = 0; r < 1; r++)
                            {
                                Console.WriteLine(string.Format("{0}. {1} 성적 : {2}", r + 1, name[r], score[r]));
                            }
                        }
                        else if (count == 2)
                        {
                            for (int k = 0; k < 2; k++)
                            {
                                Console.WriteLine(string.Format("{0}. {1} 성적 : {2}", k + 1, name[k], score[k]));
                            }
                        }
                        else
                        {
                            for (int i = 0; i < max; i++)
                            {
                                Console.WriteLine(string.Format("{0}. {1} 성적 : {2}", i + 1, name[i], score[i]));
                            }
                        }
                        break;
                    case 5:
                        return; //아예 빠져나감

                }

                Console.WriteLine();
            }
                        
                }
            }
        }
  
