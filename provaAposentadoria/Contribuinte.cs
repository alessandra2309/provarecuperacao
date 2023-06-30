

public class contribuinte
{
    public string nome;
    public string cpf;
    public double DataNascimento;
    public string sexo;
    public string profissao;
    public double iniciotrabalho;

     private string get()
     {
        return nome;
     }
    public void set(string nome)
    {
        this.nome = nome;
    }
    private string get2()
    {
        return cpf;
    }
    public void set2(string cpf)
    {
        this.cpf = cpf;
    }
    private double get3()
    {
        return DataNascimento;
    }
    public void set3(double DataNascimento)
    {
        this.DataNascimento = DataNascimento;
    }

    private string get4()
    {
        return sexo;
    }
    public void set4(string sexo)
    {
        this.sexo = sexo;   
    }

    private string get5()
    {
        return profissao;
    }
    public void set5(string profissao)
    {
        this.profissao = profissao;
    }

    private double get6()
    {
        return iniciotrabalho;
    }
    public void set6(double iniciotrabalho)
    {
        this.iniciotrabalho = iniciotrabalho;
    }


    public double Calcular()
    {
        double conta = this.DataNascimento + this.iniciotrabalho;
        double cont = 0;


        if (sexo == "Feminino")
        {
            if (conta < 95)
            {
                cont = conta - 95;

            }
           
            if (profissao == "Professor")
            {
                if (conta < 85)
                {
                    cont = conta - 85;
                }

            }

            else if (profissao == " agentes de segurança")
            {
                if(conta < 85)
                {
                    cont = (conta - 85);
                }
                
            }

            else if (profissao == " saúde")
            {
                if(conta < 95)
                {
                    cont = conta - 95;
                }
                else if(conta < 95)
                {

                }
               
            }

            else if (profissao == "demais serviços")
            {
                if(conta < 95)
                {
                    cont = conta - 95;
                }
                else if(conta < 95)
                {

                }
            }


        }



        else if (sexo == "Masculino")
        {
            if (conta < 105)
            {
                cont = conta - 105;

            }


            else if (conta < 105)
            {

            }

            else if (profissao != "Professor")
            {
                if (conta < 95)
                {
                    cont = conta - 95;
                }
               
            }
            else if (profissao == " agentes de segurança")
            {
               if(conta < 95)
                {
                    cont = conta - 95;
                }
            }

            else if (profissao == " saúde")
            {
                cont = conta - 105;
            }

            else if (profissao == "demais serviços")
            {
                cont = conta - 105;
            }
        }
        return cont;
    }


        
 }



