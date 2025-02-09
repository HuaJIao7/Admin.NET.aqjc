// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using Admin.NET.Application.Entity;
namespace Admin.NET.Application.Service.ljsj;

/// <summary>
/// 查询 🧩
/// </summary>
// [AllowAnonymous]
[ApiDescriptionSettings(ApplicationConst.GroupName, Order = 100)]
public class ljsjService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<Entity.ljsj> _ljsj;
    private readonly SqlSugarRepository<ljsj_csmk> _ljsj_csmk;
    private readonly SqlSugarRepository<ljsj_ddjj> _ljsj_ddjj;
    private readonly SqlSugarRepository<ljsj_ddlj> _ljsj_ddlj;
    private readonly SqlSugarRepository<ljsj_dhmk> _ljsj_dhmk;
    private readonly SqlSugarRepository<ljsj_dsmk> _ljsj_dsmk;
    private readonly SqlSugarRepository<ljsj_pgmk> _ljsj_pgmk;
    private readonly SqlSugarRepository<ljsj_rhyk> _ljsj_rhyk;
    private readonly SqlSugarRepository<ljsj_xfmk> _ljsj_xfmk;
    private readonly SqlSugarRepository<ljsj_xhmk> _ljsj_xhmk;
    
    public ljsjService(SqlSugarRepository<Entity.ljsj> ljsj, SqlSugarRepository<ljsj_csmk> ljsjCsmk, SqlSugarRepository<ljsj_ddjj> ljsjDdjj, SqlSugarRepository<ljsj_ddlj> ljsjDdlj, SqlSugarRepository<ljsj_dhmk> ljsjDhmk, SqlSugarRepository<ljsj_dsmk> ljsjDsmk, SqlSugarRepository<ljsj_pgmk> ljsjPgmk, SqlSugarRepository<ljsj_rhyk> ljsjRhyk, SqlSugarRepository<ljsj_xfmk> ljsjXfmk, SqlSugarRepository<ljsj_xhmk> ljsjXhmk)
    {
        _ljsj = ljsj;
        _ljsj_csmk = ljsjCsmk;
        _ljsj_ddjj = ljsjDdjj;
        _ljsj_ddlj = ljsjDdlj;
        _ljsj_dhmk = ljsjDhmk;
        _ljsj_dsmk = ljsjDsmk;
        _ljsj_pgmk = ljsjPgmk;
        _ljsj_rhyk = ljsjRhyk;
        _ljsj_xfmk = ljsjXfmk;
        _ljsj_xhmk = ljsjXhmk;
    }
    [DisplayName("获取列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getljsj"), HttpPost]
    public async Task<dynamic> Getljsj(BasePageInput input ,string name, string tableName)
    {
        var db = _ljsj.Context;
        var query = db.QueryableByObject(tableName);
        return await query.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
}