using System;

namespace DemoApp_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // tamamamam
            // After Modify

            #region Math
            //   double f=  Math.Truncate(3.6);
            //   Console.WriteLine(f);

            //int min=   Math.Min(4, Math.Min(2,  Math.Min(3,1) ));
            //   Console.WriteLine(min);
            #endregion

            #region demo

            //Console.WriteLine("enter Number ");
            //double x = double.Parse(Console.ReadLine());

            //double total = (x + 1) / 2 * x;

            //Console.WriteLine("total is "+total);
            #endregion


            #region Implicit and Explicit Casting
            //

            //byte x = 255;
            //int y =(int) x;
            //Console.WriteLine(y);

            //checked
            //{
            //    short x = 300;
            //    byte y = (byte)    (x +2 *x -200);
            //    Console.WriteLine(y);
            //}

            #endregion


            #region  Handel Exception
            //try
            //{
            //    Console.WriteLine("Enter Number ");
            //    int x = int.Parse(Console.ReadLine());



            //    Console.WriteLine("Enter Number ");
            //    int y = int.Parse(Console.ReadLine());


            //    int z = x / y;

            //    Console.WriteLine("divid is " + z);


            //}
            ////catch (DivideByZeroException)
            ////{
            ////    Console.WriteLine("zerooooooooooo");
            ////}
            ////catch(FormatException)
            ////{
            ////    Console.WriteLine("formattttttttttttt");
            ////}
            ////catch(OverflowException)
            ////{
            ////    Console.WriteLine("overflowwwwwwwwwwwwwww");
            ////}

            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);

            //}
            //finally
            //{

            //    Console.WriteLine("thanks ");
            //}

            #endregion

            #region Pre proccessor Compiler 
#if DEBUG
            // int x = 5;

#else
          //  int x = 10;
#endif


            // Console.WriteLine(x);

            #endregion



            #region Selection Statment     

            // If


            //int x = 300;

            //if (x > 100 && x<1000)
            //{
            //    Console.WriteLine("greater than 100");
            //}
            //else
            //{
            //    if (x < 100)
            //    {
            //        Console.WriteLine("less than 100");
            //    }
            //    else
            //    {
            //        Console.WriteLine("equal 100");
            //    }
            //}



            //---------------------------
            //int x = 3;

            //switch(x)
            //{
            //    default:
            //        Console.WriteLine("default");
            //        break;


            //    case 2:
            //    case 15:
            //    case 20:
            //        Console.WriteLine("22222222222222");
            //        break;

            //    case 5: Console.WriteLine("55555555555555");
            //        break;


            //}



            #endregion



            #region Iteration Statment
            //int x = 1000;
            //while (x < 10)
            //{
            //    //code
            //    Console.WriteLine("welcome");

            //    x = x + 1;
            //} ;




            //for(int x=1; x<10; x=x+1  )
            //{
            //    //code
            //    Console.WriteLine(x);
            //}


            #endregion


            #region Jump Stament

            //for (int i = 1; i <= 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //    Console.WriteLine("thanks");
            //}


            //int x = 1;
            //aa:
            //Console.WriteLine(x);
            //x = x + 1;
            //if (x == 10)
            //    goto end;
            //goto aa;

            //end:
            //Console.WriteLine("done");


            #endregion



            //int [] x = { 3, 5, 7, 8,55,77,99 };

            //var en = x.GetEnumerator();

            //while(en.MoveNext())
            //{
            //    Console.WriteLine(en.Current);
            //}


            //int x = int.Parse(Console.ReadLine());
            //int[] arr = new int[x];

            //arr[0] = 22;
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[2]);
            //Console.WriteLine(arr[3]);
            //Console.WriteLine(arr[4]);





            //  One Dimension     , Multi Dimension  , Jagged Array


            // int[] dgree = new int[100];
            //dgree[0]= 22;


            //int[,] dgree = new int[4,25];
            //dgree[0, 0] = 22;

            //for (int i = 0; i <= 3; i++)
            //{

            //    for (int j = 0; j < 25; j++)
            //    {
            //        dgree[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //int[,,] dgree = new int[2,5,10];



            double[][] dgree = new double[4][];
            dgree[0] = new double[20];
            dgree[0][0] = 22;


            dgree[1] = new double[30];



        }
    }
}
