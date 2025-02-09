// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

namespace Admin.NET.Application.Entity;

public class wfsj_xfmk
{
    #region wfsj 构造函数
    /// <summary>
    /// 主键
    /// </summary>
    public long id { get; set; }

    /// <summary>
    /// 测点编号(唯一，与 CDDY 文件中测点编号应) （必填项）
    /// </summary>
    public string? cdbh { get; set; }

    /// <summary>
    /// 传感器类型名称（必填项，参考传感器类型对应名称）
    /// </summary>
    public string? cgqlxmc { get; set; }

    /// <summary>
    /// 测点安装位置（必填项）
    /// </summary>
    public string? cdazwz { get; set; }

    /// <summary>
    /// 测点数值单位（必填项）
    /// </summary>
    public string? cdszdw { get; set; }

    /// <summary>
    /// 5 分钟内平均值{浮点类型，小数点后 2 位}（必填项）
    /// </summary>
    public string? wfpjz { get; set; }

    /// <summary>
    /// 5 分钟内最大值{浮点类型，小数点后 2 位}（必填项）
    /// </summary>
    public string? wfzdz { get; set; }

    /// <summary>
    /// 5 分钟内最大值时刻，例如：2015-11-29 10:35:03（必填项）
    /// </summary>
    public string? wfzdsk { get; set; }

    /// <summary>
    /// 5 分钟内最小值{浮点类型，小数点后 2 位}（必填项）
    /// </summary>
    public string? wfzxz { get; set; }

    /// <summary>
    /// 5 分钟内最小值时刻，例如：2015-11-29 10:35:03（必填项）
    /// </summary>
    public string? wfzxsk { get; set; }

    /// <summary>
    /// 开始时间（日期时间格式yyyy-MM-dd hh:mm:ss，必填项）
    /// </summary>
    public string? kssj { get; set; }

    /// <summary>
    /// 结束时间（日期时间格式yyyy-MM-dd hh:mm:ss，必填项）
    /// </summary>
    public string? jssj { get; set; }
    
    /// <summary>
    /// 所属的矿
    /// </summary>
    public string? ssk { get; set; }
    #endregion
}