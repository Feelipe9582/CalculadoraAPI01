namespace CalculadoraAPI.Models
{
    public class MultiplicacaoRequest
    {
        public string Numero1 { get; set; }
        public string Numero2 { get; set; }
    }

    public class MediaRequest
    {
        public string Numero1 { get; set; }
        public string Numero2 { get; set; }
    }

    public class RaizQuadradaRequest
    {
        public string Numero { get; set; }
    }

    public class MultiplicacaoResponse
    {
        public string Resultado { get; set; }
    }

    public class MediaResponse
    {
        public string Resultado { get; set; }
    }

    public class RaizQuadradaResponse
    {
        public string Resultado { get; set; }
    }
}
