var iso = Encoding.GetEncoding("ISO-8859-1");
var utf8 = Encoding.UTF8;
byte[] utfBytes = utf8.GetBytes(input);
byte[] isoBytes = Encoding.Convert(utf8, iso, utfBytes);
string result = iso.GetString(isoBytes);
