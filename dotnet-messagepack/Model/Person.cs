using MessagePack;

namespace dotnet_messagepack.Model;

[MessagePackObject]
public class Pessoa
{
    [Key("nome")]
    public string Nome { get; set; }

    [Key("idade")]
    public int Idade { get; set; }

    [Key("cidade")]
    public string Cidade { get; set; }
}

