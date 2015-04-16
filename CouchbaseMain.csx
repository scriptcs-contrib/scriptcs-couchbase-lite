using Couchbase.Lite;

public static Database GetDb(string name) {
    var db = Manager.SharedInstance.GetDatabase("name");
    return db;
}
