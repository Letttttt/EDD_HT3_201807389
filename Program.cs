namespace HelloWorld
{
    class Program
    {
        int[] burbujabidireccional(int[] arreglo)
        {
            int inicio = 0;
            int final = arreglo.Length -1;
            bool cambio = true;
            while(cambio)
            {                
                for (int i = inicio; i < final -inicio; i++)
                {
                    if (arreglo[i] > arreglo[i+1])
                    {
                        int temporal = arreglo[i];
                        arreglo[i] = arreglo[i+1];
                        arreglo[i+1] = temporal;
                    }
                } 

                for (int i = final -inicio; i > inicio; i--)
                {
                    if (arreglo[i-1] > arreglo[i])
                    {
                        int temporal = arreglo[i-1];
                        arreglo[i-1] = arreglo[i];
                        arreglo[i] = temporal;
                    }
                } 
                inicio++;
                if(inicio == arreglo.Length)
                {
                    break;
                }                
                
            }     
            return arreglo;
        }
        static void Main(string[] args)
        {
            Program tarea = new Program();
            int[] data = {1,4,19,8986,46,98,35,30,45,355,4,84,32,94,65,76,65,38,99,392,9,22,54,100,68,93,566,3,342,823,0,2,45,23,95, 27, 884, 3444,33,832};
            data = tarea.burbujabidireccional(data);
            Console.WriteLine(string.Join(",",data));
        }
    }
}