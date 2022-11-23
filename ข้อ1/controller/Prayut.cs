public class Prayut
{
    CircularLinkedList<char> list = new CircularLinkedList<char>();
   
        char Input()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Input Flower");
            return Char.ToUpper((Console.ReadKey().KeyChar));
        }

        public void New()
        {
            Check(Input());
        }

        void Check(char x)
        {
                char[] key = new char[] { 'J', 'G', 'O','R' };
                foreach (var item in key)
                {
                    if(x == item){                      
                        if (x == key[0])
                        {
                            bool z = J(x);   
                            if (!z)
                            {
                                PrintInvalid();
                            }
                        }
                        if (x == key[1])
                        {
                            bool z = G(x);  
                            if (!z)
                            {
                                PrintInvalid();
                            }
                        }
                        if (x == key[2])
                        {
                            bool z = O(x);
                            if (!z)
                            {
                                PrintInvalid();
                            }                            
                        }
                        if (x == key[3])
                        {
                            bool z = R(x);
                            if (!z)
                            {
                                PrintInvalid();
                            }                            
                        }
                        New();
                    }
                }
        }

        bool J(char x) //ดอกมะลิ
        {
            int n = list.GetLength();
            if (n > 0)
            {
                if (list.Get(n-1) == 'R' && list.Get(n-2) == x)
                {
                    return false;             
                }
          
                else
                {
                    list.Add(x); 
                }
            }
            else
            {
              list.Add(x); 
            }   
            return true;
        }
        bool G(char x) //ดอกบานไม่รู้โรยจะเรียงติดต่อกันได้ไม่เกิน 3 ดอก
        {               
            int n = list.GetLength();

            if (n > 0)
            {
                if (list.Get(n-1) == 'R' && list.Get(n-2) == x)
                {
                    return false;             
                }
            if (n > 2 )
            {
                if (list.Get(n-1) == x && list.Get(n-2) == x && list.Get(n-3) == x)
                {
                    return false;             
                }
                if (list.Get(0) == x && list.Get(n-3) == x)
                {
                    return false;             
                }
            }

                else
                {
                    list.Add(x); 
                }
            }
            
            else
            {
              list.Add(x); 
            }     
        return true;

        }
        bool O(char x) //ดอกกล้วยไม้
        {
            int n = list.GetLength();
            if (n > 0)
            {
                if (list.Get(n-1) == 'R' && list.Get(n-2) == x)
                {
                    return false;             
                }

                else
                {
                    list.Add(x); 
                }
            }
            
            else
            {
              list.Add(x); 
            }     
        return true;
        }
        bool R(char x) //ดอกกุหลาบจะต้องอยู่ระหว่าง ดอกไม้ 2 ชนิดที่แตกต่างกัน
        {

            int n = list.GetLength();
            if (n < 1)
            {
                return false;
            }
            if (n > 0)
            {
                if (list.Get(n-1) == x && list.Get(n-2) == x)
                {
                    return false;             
                }
                if (list.Get(0) == x && list.Get(n-3) == x)
                {
                    return false;             
                }
                if (n > 2)
                {

                    if (list.Get(n-1) == 'J' && list.Get(0) == 'J')
                    {
                            return false;           
                    }                     
                    if (list.Get(n-1) == 'G' && list.Get(0) == 'G')
                    {
                            return false;           
                    }                     
                    if (list.Get(n-1) == 'O' && list.Get(0) == 'O')
                    {
                            return false;           
                    }
                    else
                    {
                    list.Add(x); 
                    }                      
                }
                    else
                    {
                        list.Add(x); 
                    }
                }
            
            else
            {
              list.Add(x); 
            }   
            return true;
        }

        void PrintInvalid()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("=======================================");
            Console.WriteLine("||                                   ||");
            Console.WriteLine("||          Invalid pattern.         ||");
            Console.WriteLine("||                                   ||");
            Console.WriteLine("=======================================");
            Console.WriteLine("--------------------------");            
        }


        public void End()
        {

            Console.WriteLine("");
            Console.WriteLine("");
            int x = list.GetLength();
            for (int i = 0; i < x; i++)
            {
                Console.Write(list.Get(i));
            }
            Console.WriteLine("");

        }
}