namespace SOLID
{
    public abstract class Fax
    {
        public string NumSerie { get; set; }
        public abstract void EnviaFax();
    }
































































    //TESTES PASSADOS

    //public static void ExibirDadosFuncionario(Funcionario funcionario) 
    //{
    //    funcionario.CalcularPreviaSalario(3.5m);
    //    Console.WriteLine($"Funcionario {funcionario.Nome}, Salario: {funcionario.Salario:c}");
    //}

    //public static void ConfigurarFuncionario(Funcionario funcionario, Gerente gerente) 
    //{
    //    funcionario.AtribuirGerente(gerente);
    //}


    //public static void Main(string[] args)
    //{
    //    Funcionario funcionario = new Funcionario("Gilberto");
    //    ExibirDadosFuncionario(funcionario);

    //    Gerente gerente = new Gerente("Edgar");
    //    ExibirDadosFuncionario(gerente);

    //    funcionario.AtribuirGerente(gerente);

    //    CEO ceo = new CEO("Denis");                     
    //}            


    //var pets = new List<Pet>() { 
    //    new Pet() { Nome = "jackie", Genero = Genero.Macho, IdadeEmMeses = 60, Tamanho= Tamanho.Grande},
    //    new Pet() { Nome = "tiriça", Genero = Genero.Macho, IdadeEmMeses = 10, Tamanho= Tamanho.Medio},
    //    new Pet() { Nome = "belinha", Genero = Genero.Femea, IdadeEmMeses = 110, Tamanho= Tamanho.Grande},
    //    new Pet() { Nome = "coçeira", Genero = Genero.Femea, IdadeEmMeses = 120, Tamanho= Tamanho.Pequeno},
    //    new Pet() { Nome = "Serrote", Genero = Genero.Macho, IdadeEmMeses = 50, Tamanho= Tamanho.Medio},
    //    new Pet() { Nome = "apolo", Genero = Genero.Macho, IdadeEmMeses = 50, Tamanho= Tamanho.Medio}
    //};

    //var petsQueDemandamTratamentoDiferenciado = from p in pets where new PetSpecification2023().IsSatisfiedBy(p) select p;

    //foreach (var p in petsQueDemandamTratamentoDiferenciado)
    //{
    //    System.Console.WriteLine($"Nome: {p.Nome}");
    ////}
    //public interface ISpecification<T> 
    //{
    //    bool IsSatisfiedBy(T t);
    //}

    //public class PetSpecification2022 : ISpecification<Pet>
    //{
    //    public bool IsSatisfiedBy(Pet t)
    //    {
    //        return t.IdadeEmMeses > 100 && t.Tamanho >= Tamanho.Medio && t.Genero == Genero.Femea;
    //    }
    //}

    //public class PetSpecification2023 : ISpecification<Pet>
    //{
    //    public bool IsSatisfiedBy(Pet t)
    //    {
    //        return t.IdadeEmMeses > 50 && t.Tamanho > Tamanho.Medio && t.Genero == Genero.Macho;
    //    }
    //}

    //public class Pet 
    //{
    //    public int IdadeEmMeses { get; set; }
    //    public string Nome { get; set; }
    //    public Tamanho Tamanho{ get; set; }
    //    public Genero Genero{ get; set; }       


    //}

    //public enum Tamanho
    //{
    //    Pequeno, Medio, Grande
    //}

    //public enum Genero
    //{
    //    Macho, Femea
    //}


}

















