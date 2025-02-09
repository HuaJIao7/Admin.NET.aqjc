// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！
using Admin.NET.Application.Entity;
namespace Admin.NET.Application.Service.cddy;

/// <summary>
/// 查询Getcddy_ljl列表 🧩
/// </summary>
[AllowAnonymous]
[ApiDescriptionSettings(ApplicationConst.GroupName, Order = 100)]
public class  cddy_ljlService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<cddy_ljl> _cddyljl;
    private readonly SqlSugarRepository<cddy_ljl_csmk> _cddy_ljl_csmk;
    private readonly SqlSugarRepository<cddy_ljl_ddlj> _cddy_ljl_ddlj;
    private readonly SqlSugarRepository<cddy_ljl_ddjj> _cddy_ljl_ddjj;
    private readonly SqlSugarRepository<cddy_ljl_dhmk> _cddy_ljl_dhmk;
    private readonly SqlSugarRepository<cddy_ljl_dsmk> _cddy_ljl_dsmk;
    private readonly SqlSugarRepository<cddy_ljl_pgmk> _cddy_ljl_pgmk;
    private readonly SqlSugarRepository<cddy_ljl_rhyk> _cddy_ljl_rhyk;
    private readonly SqlSugarRepository<cddy_ljl_xfmk> _cddy_ljl_xfmk;
    private readonly SqlSugarRepository<cddy_ljl_xhmk> _cddy_ljl_xhmk;
    
    public  cddy_ljlService(SqlSugarRepository<cddy_ljl> cddyLjl, SqlSugarRepository<cddy_ljl_csmk> cddyLjlCsmk, SqlSugarRepository<cddy_ljl_ddjj> cddyLjlDdjj, SqlSugarRepository<cddy_ljl_dhmk> cddyLjlDhmk, SqlSugarRepository<cddy_ljl_ddlj> cddyLjlDdlj, SqlSugarRepository<cddy_ljl_dsmk> cddyLjlDsmk, SqlSugarRepository<cddy_ljl_pgmk> cddyLjlPgmk, SqlSugarRepository<cddy_ljl_rhyk> cddyLjlRhyk, SqlSugarRepository<cddy_ljl_xfmk> cddyLjlXfmk, SqlSugarRepository<cddy_ljl_xhmk> cddyLjlXhmk)
    {
        _cddyljl = cddyLjl;
        _cddy_ljl_csmk = cddyLjlCsmk;
        _cddy_ljl_ddjj = cddyLjlDdjj;
        _cddy_ljl_dhmk = cddyLjlDhmk;
        _cddy_ljl_ddlj = cddyLjlDdlj;
        _cddy_ljl_dsmk = cddyLjlDsmk;
        _cddy_ljl_pgmk = cddyLjlPgmk;
        _cddy_ljl_rhyk = cddyLjlRhyk;
        _cddy_ljl_xfmk = cddyLjlXfmk;
        _cddy_ljl_xhmk = cddyLjlXhmk;
    }
    
    [DisplayName("获取cddy_ljl列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_ljl"), HttpPost]
    public async Task<List<cddy_ljl>> Getcddy_ljl(BasePageInput input ,string name)
    {
        var entity = _cddyljl.AsQueryable().Select<cddy_ljl>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_ljl_csmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_ljl_csmk"), HttpPost]
    public async Task<List< cddy_ljl_csmk>> Getcddy_ljl_csmk(BasePageInput input ,string name)
    {
        var entity = _cddy_ljl_csmk.AsQueryable().Select< cddy_ljl_csmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_ljl_ddjj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_ljl_ddjj"), HttpPost]
    public async Task<List<cddy_ljl_ddjj>> Getcddy_ljl_ddjj(BasePageInput input ,string name)
    {
        var entity = _cddy_ljl_ddjj.AsQueryable().Select<cddy_ljl_ddjj>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_ljl_ddlj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_ljl_ddlj"), HttpPost]
    public async Task<List< cddy_ljl_ddlj>> Getcddy_ljl_ddlj(BasePageInput input ,string name)
    {
        var entity = _cddy_ljl_ddlj.AsQueryable().Select<cddy_ljl_ddlj>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_ljl_dhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_ljl_dhmk"), HttpPost]
    public async Task<List< cddy_ljl_dhmk>> Getcddy_ljl_dhmk(BasePageInput input ,string name)
    {
        var entity = _cddy_ljl_dhmk.AsQueryable().Select<cddy_ljl_dhmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_ljl_dsmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_ljl_dsmk"), HttpPost]
    public async Task<List< cddy_ljl_dsmk>> Getcddy_ljl_dsmk(BasePageInput input ,string name)
    {
        var entity = _cddy_ljl_dsmk.AsQueryable().Select<cddy_ljl_dsmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_ljl_pgmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_ljl_pgmk"), HttpPost]
    public async Task<List< cddy_ljl_pgmk>> Getcddy_ljl_pgmk(BasePageInput input ,string name)
    {
        var entity = _cddy_ljl_pgmk.AsQueryable().Select<cddy_ljl_pgmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取 cddy_ljl_rhyk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_ljl_rhyk"), HttpPost]
    public async Task<List< cddy_ljl_rhyk>> Getcddy_ljl_rhyk(BasePageInput input ,string name)
    {
        var entity = _cddy_ljl_rhyk.AsQueryable().Select<cddy_ljl_rhyk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_ljl_xfmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_ljl_xfmk"), HttpPost]
    public async Task<List< cddy_ljl_xfmk>> Getcddy_ljl_xfmk(BasePageInput input ,string name)
    {
        var entity = _cddy_ljl_xfmk.AsQueryable().Select<cddy_ljl_xfmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_ljl_xhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_ljl_xhmk"), HttpPost]
    public async Task<List< cddy_ljl_xhmk>> Getcddy_ljl_xhmk(BasePageInput input ,string name)
    {
        var entity = _cddy_ljl_xhmk.AsQueryable().Select<cddy_ljl_xhmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
}
