class Clients {
    private string[] clientName = new string[10];

    public string this[int idx] {
        get {
            return clientName[idx];
        }
        set {
            clientName[idx] = value;
        }
    }
}