namespace MyRecipeBook.Exceptions.ExceptionsBase;

public class ErrorOnValidationException : MyRecipeBookException
{
    public IList<string> ErrorMessages { get; set; }

    public ErrorOnValidationException(IList<String> errosMessages)
    {
        ErrorMessages = errosMessages;
    }
}
