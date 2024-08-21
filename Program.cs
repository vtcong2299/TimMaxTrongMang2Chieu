using System;

namespace TimMaxTrongMang2Chieu
{
    class Program
    {
        static void Main(string[]args)
        {
            int row;
            int col;
            int i,j;  
            int max = 0;          
            while(true)
            {
                Console.Write("Nhap vao so dong cua mang: ");
                if (int.TryParse(Console.ReadLine(),out row)&& row >0)
                {
                    break;
                }
                continue;
            }
            while(true)
            {
                Console.Write("Nhap vao so cot cua mang: ");
                if (int.TryParse(Console.ReadLine(),out col)&& col >0)
                {
                    break;
                }
                continue;
            }
            int [,] array = new int [row,col];
            for(i=0;i<row;i++)
            {
                for(j=0;j<col;j++)
                {                    
                    while(true)
                    {
                        Console.Write("Nhap vao gia tri phan tu array[{0},{1}]: ",i,j);
                        if (int.TryParse(Console.ReadLine(),out array[i,j]))
                        {
                            break;
                        }
                        continue;
                    }
                }
            }
            Console.WriteLine("Mang vua nhap la: ");
            for(i=0;i<row;i++)
            {
                for(j=0;j<col;j++)
                {                    
                    Console.Write("{0,5}",array[i,j]);
                }
                Console.WriteLine();
            }
            for(i=0;i<row;i++)
            {
                for(j=0;j<col;j++)
                {                    
                    if(array[i,j]>max)
                    {
                        max=array[i,j];
                    }
                }                
            }
            Console.WriteLine("Gia tri lon nhat trong mang la: "+max);
        }
    }
}