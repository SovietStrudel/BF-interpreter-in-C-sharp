// See https://aka.ms/new-console-template for more information

 class Program {
    static void Main(string[] args) {
        string code = File.ReadAllText("bf.helloworld");
        
        int depth; 
        int pointer = 0;
        char[] tape = new char[1000];
         int i = 0;
         while (i < code.Length) {
           char current = code[i];
            if (current == '>') {
                pointer ++;
            } else if(current == '<') {
                pointer --;
            } else if (current == '+') {
                tape[pointer] ++;
            } else if (current == '-') {
                tape[pointer] --;
            } else if(current == '.') {
                char p = (tape[pointer]);
                Console.Write(p);
            } else if(current == ',') {
                char pp = (char) Console.Read();
                tape[pointer] = pp;
            } else if (current == '[') {
                if (tape[pointer] == 0 ) {
                    depth = 1;
                
                 while (depth > 0) {
                        i++;
                      if (code[i] == '[' ) {
                        depth ++;
                      } else if(code[i] == ']') {
                        depth --;
                     }
                        
                    }
                    i++;
           
                }
            } else if  (current == ']') {
                    if (tape[pointer] != 0) {
                        depth = 1;
                        while (depth > 0) {
                            i--;
                            if (code[i] == '[') {
                                depth --;
                            } else if (code[i] == ']') {
                                depth++;
                            }
                           
                        }
                        i--;
                    }
            }
            i++;
         }

    }
}
 