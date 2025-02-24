
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg
{
public sealed partial class Pos3 : Luban.BeanBase
{
    public Pos3(ByteBuf _buf) 
    {
        Xx = _buf.ReadFloat();
        Yy = _buf.ReadFloat();
        Zz = _buf.ReadFloat();
    }

    public static Pos3 DeserializePos3(ByteBuf _buf)
    {
        return new Pos3(_buf);
    }

    /// <summary>
    /// 位置x值
    /// </summary>
    public readonly float Xx;
    /// <summary>
    /// 位置y值
    /// </summary>
    public readonly float Yy;
    /// <summary>
    /// 位置z值
    /// </summary>
    public readonly float Zz;
   
    public const int __ID__ = 2493567;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "xx:" + Xx + ","
        + "yy:" + Yy + ","
        + "zz:" + Zz + ","
        + "}";
    }
}

}

