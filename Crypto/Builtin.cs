namespace Crypto;

public static class Builtin
{
    private static string[] elements = new[]
    {
        "4dn9Sycy!ev)8f%_,Yay~pAj)~k4q!hNz,FHuWHFQe%+P*eW24Ac)yTAGeF$pJ)!7BU!9#ke%|3Ai%*jMa(Vi~B2j*L(uyvE/9cE$E_,WwV4irL$5RXgaC4ufu/4FB5p",
        "j%.i.LL|rL,+d6JA",
        "EZTv,6~NZQv(X9DU"
    };

    public static string GetKey(int index)
    {
        return StrCnv1.Cnv(elements[index]);
    }
}