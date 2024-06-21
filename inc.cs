public static TType FromString<TType>(string input) {
    var byteArray = Encoding.ASCII.GetBytes(input);
    using (var stream = new MemoryStream(byteArray)) {
        var bf = new BinaryFormatter();
        return (TType)bf.Deserialize(stream);
    }
}
