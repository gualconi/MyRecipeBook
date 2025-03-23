namespace MyRecipeBook.Communication.Responses;

public class ResponseErrorJson
{
    public IList<string> Errors { get; set; }

    public ResponseErrorJson(IList<string> erros) => Errors = erros;

    public ResponseErrorJson(string error)
    {
        Errors = [error];
    }
}
