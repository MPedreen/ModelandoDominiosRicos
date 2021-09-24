namespace PaymentContext.Shared.Commands
{
    //As vezes o command de entrada nao é o mesmo de saida. Exemplo: quando vc vai criar um novo usuario, manda pra api o username, password e a confirmacao do password, depois que cadastrou o usuario, retorna os dados pra tela, mas nao vai retornar a senha do usuario pra tela e sim o username o id do usuario que foi gerado. Por isso a utilização do commandresult.
    public interface ICommandResult
    {

    }
}