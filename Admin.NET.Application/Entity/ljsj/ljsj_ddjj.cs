// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

namespace Admin.NET.Application.Entity;

public class ljsj_ddjj
{
    #region ljsj 构造函数
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 测点编号(唯一，与 CDDY 文件中测点编号对应) （必填项）
    /// </summary>
    public string? cdbh { get; set; }

    /// <summary>
    /// 当前班次{整型}，指当前班次定义的索引，从 0 开始。（必填项）
    /// </summary>
    public string? dqbc { get; set; }

    /// <summary>
    /// 第一班值{浮点类型，小数点后 2 位}（必填项）
    /// </summary>
    public string? dybz { get; set; }

    /// <summary>
    /// 第二班值{浮点类型，小数点后 2 位}（必填项）
    /// </summary>
    public string? debz { get; set; }

    /// <summary>
    /// 第三班值{浮点类型，小数点后 2 位}（必填项）
    /// </summary>
    public string? dsbz { get; set; }

    /// <summary>
    /// 第四班值{浮点类型，小数点后 2 位}，本单位不存在四班时，数值为空
    /// </summary>
    public string? dsibz { get; set; }

    /// <summary>
    /// 所属的矿
    /// </summary>
    public string? ssk { get; set; }
    #endregion
}