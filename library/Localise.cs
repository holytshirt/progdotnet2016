
namespace Language
{
    public class Localise
    {
        public string Translate(string alphaTwoCode)
        {
            if(alphaTwoCode == "en")
            {
                return "Hello World!";
            }
            
            if (alphaTwoCode == "fr")
            {
                return "Bonjour le monde";
            }

            if (alphaTwoCode == "es")
            {
                return "Hola Mundo";
            }

            return "Hello World";
        }
        
    }
}
