namespace Model;

public abstract class BasicModel{

    public List<string> Errors { get; set; } = new List<string>();

    public void AddValidation(bool isInvalid, string message){
        if(isInvalid)
            Errors.Add(message);
    }

    public bool Valid(){
        return Errors.Count() == 0;
    }
}
