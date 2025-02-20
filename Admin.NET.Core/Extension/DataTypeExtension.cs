// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
//
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
//
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

namespace Admin.NET.Core;

/// <summary>
/// 基本数据类型扩展（作为NewLife.Core的Utility的补充）
/// </summary>
public static class DataTypeExtension
{
    /// <summary>转为SByte整数，转换失败时返回默认值。</summary>
    /// <remarks></remarks>
    /// <param name="value">待转换对象</param>
    /// <param name="defaultValue">默认值。待转换对象无效时使用</param>
    /// <returns></returns>
    public static sbyte ToSByte(this object value, sbyte defaultValue = default)
    {
        if (value is sbyte num) return num;
        if (value == null || value == DBNull.Value) return defaultValue;

        if (sbyte.TryParse(value.ToString(), out var result))
            return result;
        else
            return defaultValue;
    }

    /// <summary>转为Byte整数，转换失败时返回默认值。</summary>
    /// <remarks></remarks>
    /// <param name="value">待转换对象</param>
    /// <param name="defaultValue">默认值。待转换对象无效时使用</param>
    /// <returns></returns>
    public static byte ToByte(this object value, byte defaultValue = default)
    {
        if (value is byte num) return num;
        if (value == null || value == DBNull.Value) return defaultValue;

        if (byte.TryParse(value.ToString(), out var result))
            return result;
        else
            return defaultValue;
    }

    /// <summary>转为Int16整数，转换失败时返回默认值。</summary>
    /// <remarks></remarks>
    /// <param name="value">待转换对象</param>
    /// <param name="defaultValue">默认值。待转换对象无效时使用</param>
    /// <returns></returns>
    public static short ToInt16(this object value, short defaultValue = default)
    {
        if (value is short num) return num;
        if (value == null || value == DBNull.Value) return defaultValue;

        if (short.TryParse(value.ToString(), out var result))
            return result;
        else
            return defaultValue;
    }

    /// <summary>转为UInt16整数，转换失败时返回默认值。</summary>
    /// <remarks></remarks>
    /// <param name="value">待转换对象</param>
    /// <param name="defaultValue">默认值。待转换对象无效时使用</param>
    /// <returns></returns>
    public static ushort ToUInt16(this object value, ushort defaultValue = default)
    {
        if (value is ushort num) return num;
        if (value == null || value == DBNull.Value) return defaultValue;

        if (ushort.TryParse(value.ToString(), out var result))
            return result;
        else
            return defaultValue;
    }

    /// <summary>转为UInt32整数，转换失败时返回默认值。</summary>
    /// <remarks></remarks>
    /// <param name="value">待转换对象</param>
    /// <param name="defaultValue">默认值。待转换对象无效时使用</param>
    /// <returns></returns>
    public static uint ToUInt32(this object value, uint defaultValue = default)
    {
        if (value is uint num) return num;
        if (value == null || value == DBNull.Value) return defaultValue;

        if (uint.TryParse(value.ToString(), out var result))
            return result;
        else
            return defaultValue;
    }

    /// <summary>转为UInt64整数，转换失败时返回默认值。</summary>
    /// <remarks></remarks>
    /// <param name="value">待转换对象</param>
    /// <param name="defaultValue">默认值。待转换对象无效时使用</param>
    /// <returns></returns>
    public static ulong ToUInt64(this object value, ulong defaultValue = default)
    {
        if (value is ulong num) return num;
        if (value == null || value == DBNull.Value) return defaultValue;

        if (ulong.TryParse(value.ToString(), out var result))
            return result;
        else
            return defaultValue;
    }
}