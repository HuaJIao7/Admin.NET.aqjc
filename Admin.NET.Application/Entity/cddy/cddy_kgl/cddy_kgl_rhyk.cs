// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

namespace Admin.NET.Application.Entity;

public class cddy_kgl_rhyk
{
    #region cddy 构造函数
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }
    
    /// <summary>
    /// 测点编码
    /// </summary>
    public string? cdbm { get; set; }
    
    /// <summary>
    /// 系统编码
    /// </summary>
    public string? xtbm { get; set; }
    
    /// <summary>
    /// 分站编码
    /// </summary>
    public string? fzbm { get; set; }
    
    /// <summary>
    /// 传感器类型
    /// </summary>
    public string? cgqbm { get; set; }
    
    /// <summary>
    /// 传感器类型
    /// </summary>
    public string? cdsz { get; set; }
    
    /// <summary>
    /// 测点名称
    /// </summary>
    public string? cdmc { get; set; }
    
    /// <summary>
    /// 测点所属区域名称
    /// </summary>
    public string? cdssqy { get; set; }
    
    /// <summary>
    /// 传感器所在区域的位置编码
    /// </summary>
    public string? cgqszqy { get; set; }
    
    /// <summary>
    /// 开描述
    /// </summary>
    public string? kms { get; set; }
    
    /// <summary>
    /// 停描述
    /// </summary>
    public string? tms { get; set; }
    
    /// <summary>
    /// 报警状态
    /// </summary>
    public string? bjzt { get; set; }
    
    /// <summary>
    /// 解报状态
    /// </summary>
    public string? jbzt { get; set; }
    
    /// <summary>
    /// 断电状态
    /// </summary>
    public string? ddzt { get; set; }
    
    /// <summary>
    /// 复电状态
    /// </summary>
    public string? fdzt { get; set; }
    
    /// <summary>
    /// 位置x
    /// </summary>
    public string? wzx { get; set; }
    
    /// <summary>
    /// 位置y
    /// </summary>
    public string? wzy { get; set; }
    
    /// <summary>
    /// 位置z
    /// </summary>
    public string? wzz { get; set; }
    
    /// <summary>
    /// 传感器关联关系（D、K、Z）具体参看表 6 传感器关联关系编码表
    /// </summary>
    public string? cgqglgx { get; set; }
    
    /// <summary>
    /// 所属库
    /// </summary>
    public string? ssk { get; set; }
    #endregion
}