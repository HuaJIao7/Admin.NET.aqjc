// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using Admin.NET.Application.Entity;

namespace Admin.NET.Application.Service.fzdy;

/// <summary>
/// 查询fzdy 🧩
/// </summary>
[AllowAnonymous]
[ApiDescriptionSettings(ApplicationConst.GroupName, Order = 100)]
public class fzdyService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<Entity.fzdy> _fzdy;
    private readonly SqlSugarRepository<fzdy_csmk> _fzdy_csmk;
    private readonly SqlSugarRepository<fzdy_ddj> _fzdy_ddj;
    private readonly SqlSugarRepository<fzdy_ddlj> _fzdy_ddlj;
    private readonly SqlSugarRepository<fzdy_dhmk> _fzdy_dhmk;
    private readonly SqlSugarRepository<fzdy_dsmk> _fzdy_dsmk;
    private readonly SqlSugarRepository<fzdy_pgmk> _fzdy_pgmk;
    private readonly SqlSugarRepository<fzdy_rhyk> _fzdy_rhyk;
    private readonly SqlSugarRepository<fzdy_xfmk> _fzdy_xfmk;
    private readonly SqlSugarRepository<fzdy_xhmk> _fzdy_xhmk;

    public fzdyService(SqlSugarRepository<Entity.fzdy> fzdy, SqlSugarRepository<fzdy_csmk> fzdyCsmk, SqlSugarRepository<fzdy_ddj> fzdyDdj, SqlSugarRepository<fzdy_ddlj> fzdyDdlj, SqlSugarRepository<fzdy_dhmk> fzdyDhmk, SqlSugarRepository<fzdy_dsmk> fzdyDsmk, SqlSugarRepository<fzdy_pgmk> fzdyPgmk, SqlSugarRepository<fzdy_rhyk> fzdyRhyk, SqlSugarRepository<fzdy_xfmk> fzdyXfmk, SqlSugarRepository<fzdy_xhmk> fzdyXhmk)
    {
        _fzdy = fzdy;
        _fzdy_csmk = fzdyCsmk;
        _fzdy_ddj = fzdyDdj;
        _fzdy_ddlj = fzdyDdlj;
        _fzdy_dhmk = fzdyDhmk;
        _fzdy_dsmk = fzdyDsmk;
        _fzdy_pgmk = fzdyPgmk;
        _fzdy_rhyk = fzdyRhyk;
        _fzdy_xfmk = fzdyXfmk;
        _fzdy_xhmk = fzdyXhmk;
    }
    
    [DisplayName("获取fzdy列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzdy"), HttpPost]
    public async Task<List<Entity.fzdy>> Getfzdy(BasePageInput input ,string name)
    {
        var entity = _fzdy.AsQueryable().Select<Entity.fzdy>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzdy_csmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzdy_csmk"), HttpPost]
    public async Task<List<fzdy_csmk>> Getfzdy_csmk(BasePageInput input ,string name)
    {
        var entity = _fzdy_csmk.AsQueryable().Select<fzdy_csmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzdy_ddj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzdy_ddj"), HttpPost]
    public async Task<List<fzdy_ddj>> Getfzdy_ddj(BasePageInput input ,string name)
    {
        var entity = _fzdy_ddj.AsQueryable().Select<fzdy_ddj>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzdy_ddlj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzdy_ddlj"), HttpPost]
    public async Task<List<fzdy_ddlj>> Getfzdy_ddlj(BasePageInput input ,string name)
    {
        var entity = _fzdy_ddlj.AsQueryable().Select<fzdy_ddlj>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzdy_dhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzdy_dhmk"), HttpPost]
    public async Task<List<fzdy_dhmk>> Getfzdy_dhmk(BasePageInput input ,string name)
    {
        var entity = _fzdy_dhmk.AsQueryable().Select<fzdy_dhmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzdy_dsmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzdy_dsmk"), HttpPost]
    public async Task<List<fzdy_dsmk>> Getfzdy_dsmk(BasePageInput input ,string name)
    {
        var entity = _fzdy_dsmk.AsQueryable().Select<fzdy_dsmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzdy_pgmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzdy_pgmk"), HttpPost]
    public async Task<List<fzdy_pgmk>> Getfzdy_pgmk(BasePageInput input ,string name)
    {
        var entity = _fzdy_pgmk.AsQueryable().Select<fzdy_pgmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzdy_rhyk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzdy_rhyk"), HttpPost]
    public async Task<List<fzdy_rhyk>> Getfzdy_rhyk(BasePageInput input ,string name)
    {
        var entity = _fzdy_rhyk.AsQueryable().Select<fzdy_rhyk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzdy_xfmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzdy_xfmk"), HttpPost]
    public async Task<List<fzdy_xfmk>> Getfzdy_xfmk(BasePageInput input ,string name)
    {
        var entity = _fzdy_xfmk.AsQueryable().Select<fzdy_xfmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzdy_xhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzdy_xhmk"), HttpPost]
    public async Task<List<fzdy_xhmk>> Getfzdy_xhmk(BasePageInput input ,string name)
    {
        var entity = _fzdy_xhmk.AsQueryable().Select<fzdy_xhmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
}