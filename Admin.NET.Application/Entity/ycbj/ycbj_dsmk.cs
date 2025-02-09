// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

namespace Admin.NET.Application.Entity;

public class ycbj_dsmk
{
    #region ycbj 构造函数
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 测点编号(唯一，与 CDDY 文件中测点编号对应) （必填项）
    /// </summary>
    public string? cdbh { get; set; }

    /// <summary>
    /// 传感器类型名称（必填项，参考传感器类型编码中的名称）
    /// </summary>
    public string? cgqlxmc { get; set; }

    /// <summary>
    /// 测点安装位置(必填项)不超过100个字符
    /// </summary>
    public string? cdazwz { get; set; }
    
    /// <summary>
    /// 测点数值单位（为模拟量时必填项，其他类型时候为空）
    /// </summary>
    public string? cdszdw { get; set; }

    /// <summary>
    /// 异常类型，参看表 5 报警/异常类型表（必填项）
    /// </summary>
    public string? yclx { get; set; }

    /// <summary>
    /// 测点当前值，如无信号或故障等，用空表示（必填项）
    /// </summary>
    public string? cddqz { get; set; }

    /// <summary>
    /// 报警门限（必填项）
    /// </summary>
    public string? bjmx { get; set; }

    /// <summary>
    /// 解报门限（必填项）
    /// </summary>
    public string? jbmx { get; set; }

    /// <summary>
    /// 异常起始时刻，例如：2015-11-29 10:35:03（必填项）
    /// </summary>
    public string? ycqssk { get; set; }

    /// <summary>
    /// 异常期间最大值(除模拟量外留空,保留2位小数) （必填项）
    /// </summary>
    public string? ycqjzdz { get; set; }

    /// <summary>
    /// 最大值时刻(除模拟量外留空)，例如：2015-11-29 10:35:03（必填项）
    /// </summary>
    public string? zdzsk { get; set; }

    /// <summary>
    /// 最小值时刻(除模拟量外留空)，例如：2015-11-29 10:35:03（必填项
    /// </summary>
    public string? zxzsk { get; set; }

    /// <summary>
    /// 异常期间平均值(除模拟量外留空,保留2位小数) （必填项）
    /// </summary>
    public string? ycqjpjz { get; set; }

    /// <summary>
    /// 异常期间最小值(除模拟量外留空,保留2位小数) （必填项）
    /// </summary>
    public string? ycqjzxz { get; set; }

    /// <summary>
    /// 异常原因（必填项。）
    /// </summary>
    public string? ycyy { get; set; }
    
    /// <summary>
    /// 处理措施（必填项。）
    /// </summary>
    public string? clcs { get; set; }

    /// <summary>
    /// 录入时间（必填项。）
    /// </summary>
    public string? lrsj { get; set; }

    /// <summary>
    /// 录入人（必填项。）
    /// </summary>
    public string? lrr { get; set; }

    /// <summary>
    /// 数据时间（必填项，传感器异常数据产生的时间，日期时间格式字符串，格式为yyyy-MM-dd hh:mm:ss。）（必填项）
    /// </summary>
    public string? sjsj { get; set; }

    /// <summary>
    /// 所属的矿
    /// </summary>
    public string? ssk { get; set; }
    #endregion
}