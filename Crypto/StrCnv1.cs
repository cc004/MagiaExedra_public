namespace Crypto;

public static class StrCnv1
{
    public static string Cnv(string src)
    {
        return new string(Enumerable.Range(0, src.Length / 2).Select(i => src[(2 * i) | 1]).ToArray());
    }

}