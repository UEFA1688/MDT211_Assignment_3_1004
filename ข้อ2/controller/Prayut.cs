public class Prayut
{
        Queue<int> list = new Queue<int>();
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
                char[] key = new char[] { 'L', 'M', 'S' };
                foreach (var item in key)
                {
                    if(x == item){                      
                        if (x == key[0])
                        {
                            list.Push(1);
                        }
                        if (x == key[1])
                        {
                            list.Push(2);

                        }
                        if (x == key[2])
                        {
                            list.Push(3);
                        }

                        New();
                    }
                }
        }

        void Factory()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            int x = list.GetLength();
            for (int i = 0; i < x; i++)
            {
                int n = list.Get(i);
                if (n == 1)
                {
                    list.Push(2);
                    list.Push(2);
                    list.Push(3);
                    list.Push(3);
                    list.Push(3);
                    list.Push(3);
                    list.Push(3);
                    list.Push(3);
                }
                if (n == 2)
                {
                    list.Push(3);
                    list.Push(3);
                    list.Push(3);
                }
                if (n == 3)
                {
                    list.Push(3);
                }
                
            }
        }
        public void End()
        {
            Factory();
            int m = list.GetLength();

            for (int i = 0; i < m; i++)
            {
                Console.Write(list.Get(i));
            }
            Console.WriteLine("");

        }

}