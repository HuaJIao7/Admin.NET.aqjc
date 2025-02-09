// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using Admin.NET.Application.Entity;
namespace Admin.NET.Application.Service.sssj;

/// <summary>
/// 查询 🧩
/// </summary>
// [AllowAnonymous]
[ApiDescriptionSettings(ApplicationConst.GroupName, Order = 100)]
public class sssjService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<Entity.sssj> _sssj;
    private readonly SqlSugarRepository<sssj_csmk> _sssj_csmk;
    private readonly SqlSugarRepository<sssj_ddjj> _sssj_ddjj;
    private readonly SqlSugarRepository<sssj_ddlj> _sssj_ddlj;
    private readonly SqlSugarRepository<sssj_dhmk> _sssj_dhmk;
    private readonly SqlSugarRepository<sssj_dsmk> _sssj_dsmk;
    private readonly SqlSugarRepository<sssj_pgmk> _sssj_pgmk;
    private readonly SqlSugarRepository<sssj_rhyk> _sssj_rhyk;
    private readonly SqlSugarRepository<sssj_xfmk> _sssj_xfmk;
    private readonly SqlSugarRepository<sssj_xhmk> _sssj_xhmk;
    
    public sssjService(SqlSugarRepository<Entity.sssj> sssj, SqlSugarRepository<sssj_csmk> sssjCsmk, SqlSugarRepository<sssj_ddjj> sssjDdjj, SqlSugarRepository<sssj_ddlj> sssjDdlj, SqlSugarRepository<sssj_dhmk> sssjDhmk, SqlSugarRepository<sssj_dsmk> sssjDsmk, SqlSugarRepository<sssj_pgmk> sssjPgmk, SqlSugarRepository<sssj_rhyk> sssjRhyk, SqlSugarRepository<sssj_xfmk> sssjXfmk, SqlSugarRepository<sssj_xhmk> sssjXhmk)
    {
        _sssj = sssj;
        _sssj_csmk = sssjCsmk;
        _sssj_ddjj = sssjDdjj;
        _sssj_ddlj = sssjDdlj;
        _sssj_dhmk = sssjDhmk;
        _sssj_dsmk = sssjDsmk;
        _sssj_pgmk = sssjPgmk;
        _sssj_rhyk = sssjRhyk;
        _sssj_xfmk = sssjXfmk;
        _sssj_xhmk = sssjXhmk;
    }

    [DisplayName("获取列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getsssj"), HttpPost]
    public async Task<List<Entity.sssj>> Getsssj(BasePageInput input ,string name)
    {
        var list = _sssj.AsQueryable().Select<Entity.sssj>();
        return await list.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取sssj_csmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getsssj_csmk"), HttpPost]
    public async Task<List<sssj_csmk>> Getsssj_csmk(BasePageInput input ,string name)
    {
        var entity = _sssj_csmk.AsQueryable().Select<sssj_csmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取sssj_ddjj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getsssj_ddjj"), HttpPost]
    public async Task<List<sssj_ddjj>> Getsssj_ddjj(BasePageInput input ,string name)
    {
        var entity = _sssj_ddjj.AsQueryable().Select<sssj_ddjj>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取sssj_ddlj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getsssj_ddlj"), HttpPost]
    public async Task<List<sssj_ddlj>> Getsssj_ddlj(BasePageInput input ,string name)
    {
        var entity = _sssj_ddlj.AsQueryable().Select<sssj_ddlj>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取sssj_dhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getsssj_dhmk"), HttpPost]
    public async Task<List<sssj_dhmk>> Getsssj_dhmk(BasePageInput input ,string name)
    {
        var entity = _sssj_dhmk.AsQueryable().Select<sssj_dhmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取sssj_dsmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getsssj_dsmk"), HttpPost]
    public async Task<List<sssj_dsmk>> Getsssj_dsmk(BasePageInput input ,string name)
    {
        var entity = _sssj_dsmk.AsQueryable().Select<sssj_dsmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取sssj_pgmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getsssj_pgmk"), HttpPost]
    public async Task<List<sssj_pgmk>> Getsssj_pgmk(BasePageInput input ,string name)
    {
        var entity = _sssj_pgmk.AsQueryable().Select<sssj_pgmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取sssj_rhyk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getsssj_rhyk"), HttpPost]
    public async Task<List<sssj_rhyk>> Getsssj_rhyk(BasePageInput input ,string name)
    {
        var entity = _sssj_rhyk.AsQueryable().Select<sssj_rhyk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取sssj_xfmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getsssj_xfmk"), HttpPost]
    public async Task<List<sssj_xfmk>> Getsssj_xfmk(BasePageInput input ,string name)
    {
        var entity = _sssj_xfmk.AsQueryable().Select<sssj_xfmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取sssj_xhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getsssj_xhmk"), HttpPost]
    public async Task<List<sssj_xhmk>> Getsssj_xhmk(BasePageInput input ,string name)
    {
        var entity = _sssj_xhmk.AsQueryable().Select<sssj_xhmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
}