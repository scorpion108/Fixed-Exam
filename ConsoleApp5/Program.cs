using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int NodeCounter(Node<int> h)
        {
            int count = 0;
            Node<int> temp = h;
            while(temp.GetNext()!= null)
            {
                temp = temp.GetNext();
                count++;
            }
            return count;
        }

       public static bool IsSection(Node<int> h)
        {
            Node<int> temp = h;
            if (temp == null)
                return true;
            temp = temp.GetNext();
            //int FullLength = NodeCounter(h);
            //int Length = NodeCounter(temp);
            for (int i = 0; i < NodeCounter(h); i++) //   הייתי צריך לעשות משתנה לאורך של המערך ואת האורך של המערך פחות אחד במקום כל פעם לחפש אותו כמו מלמעלה 
            {
                for (int j = 0; j < NodeCounter(temp); j++)
                {
                    if (h.GetValue() > temp.GetValue())
                        return false;
                }
                h = h.GetNext();
                temp = temp.GetNext();
            }
            return true;    //i didnt do it
        }

        public static void DeleteDeffect(Node<int> h)
        {
            while (h != null)
            {
                if (h.GetValue() > (NodeCounter(h) ))   //ERROR
                {
                    if (h.GetNext().GetNext() != null)  //ERROR
                        h.SetNext(h.GetNext().GetNext());   //ERROR
                    else
                        h.SetNext(null);    //ERROR 
                }
                h = h.GetNext();    //ERROR
            }

        }


        
    }
}
