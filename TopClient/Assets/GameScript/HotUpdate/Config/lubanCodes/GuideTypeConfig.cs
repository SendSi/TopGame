
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
public sealed partial class GuideTypeConfig : Luban.BeanBase
{
    public GuideTypeConfig(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        TypeName = _buf.ReadString();
        CheckAct = _buf.ReadInt();
    }

    public static GuideTypeConfig DeserializeGuideTypeConfig(ByteBuf _buf)
    {
        return new GuideTypeConfig(_buf);
    }

    /// <summary>
    /// key值
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 道具名称
    /// </summary>
    public readonly string TypeName;
    /// <summary>
    /// 检测执行
    /// </summary>
    public readonly int CheckAct;
   
    public const int __ID__ = -1073516776;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "typeName:" + TypeName + ","
        + "checkAct:" + CheckAct + ","
        + "}";
    }
}

}

