// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using Admin.NET.Application.Entity;

namespace Admin.NET.Application.Service.cddy_dtl;

/// <summary>
/// 查询cddy_dtl_dtl列表 🧩
/// </summary>
[AllowAnonymous]
[ApiDescriptionSettings(ApplicationConst.GroupName, Order = 100)]
public class  cddy_dtl : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<Entity.cddy_dtl> _cddy_dtl;
    private readonly SqlSugarRepository<cddy_dtl_csmk> _cddy_dtl_csmk;
    private readonly SqlSugarRepository<cddy_dtl_ddj> _cddy_dtl_ddj;
    private readonly SqlSugarRepository<cddy_dtl_ddlj> _cddy_dtl_ddlj;
    private readonly SqlSugarRepository<cddy_dtl_dhmk> _cddy_dtl_dhmk;
    private readonly SqlSugarRepository<cddy_dtl_dsmk> _cddy_dtl_dsmk;
    private readonly SqlSugarRepository<cddy_dtl_pgmk> _cddy_dtl_pgmk;
    private readonly SqlSugarRepository<cddy_dtl_rhyk> _cddy_dtl_rhyk;
    private readonly SqlSugarRepository<cddy_dtl_xfmk> _cddy_dtl_xfmk;
    private readonly SqlSugarRepository<cddy_dtl_xhmk> _cddy_dtl_xhmk;
    
    public  cddy_dtl(SqlSugarRepository<Entity.cddy_dtl> cddy_dtl, SqlSugarRepository<cddy_dtl_csmk> cddyDtlCsmk, SqlSugarRepository<cddy_dtl_ddj> cddyDtlDdj, SqlSugarRepository<cddy_dtl_ddlj> cddyDtlDdlj, SqlSugarRepository<cddy_dtl_dhmk> cddyDtlDhmk, SqlSugarRepository<cddy_dtl_dsmk> cddyDtlDsmk, SqlSugarRepository<cddy_dtl_pgmk> cddyDtlPgmk, SqlSugarRepository<cddy_dtl_rhyk> cddyDtlRhyk, SqlSugarRepository<cddy_dtl_xfmk> cddyDtlXfmk, SqlSugarRepository<cddy_dtl_xhmk> cddyDtlXhmk)
    {
        _cddy_dtl = cddy_dtl;
        _cddy_dtl_csmk = cddyDtlCsmk;
        _cddy_dtl_ddj = cddyDtlDdj;
        _cddy_dtl_ddlj = cddyDtlDdlj;
        _cddy_dtl_dhmk = cddyDtlDhmk;
        _cddy_dtl_dsmk = cddyDtlDsmk;
        _cddy_dtl_pgmk = cddyDtlPgmk;
        _cddy_dtl_rhyk = cddyDtlRhyk;
        _cddy_dtl_xfmk = cddyDtlXfmk;
        _cddy_dtl_xhmk = cddyDtlXhmk;
    }
    
    [DisplayName("获取_cddy_dtl列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "GetList"), HttpPost]
    public async Task<List<cddy_dtl>> GetList(BasePageInput input ,string name)
    {
        var entity = _cddy_dtl.AsQueryable().Select<cddy_dtl>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_dtl_csmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_dtl_csmk"), HttpPost]
    public async Task<List<cddy_dtl_csmk>> Getcddy_dtl_csmk(BasePageInput input ,string name)
    {
        var entity = _cddy_dtl_csmk.AsQueryable().Select<cddy_dtl_csmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取 cddy_dtl_ddj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_dtl_ddj"), HttpPost]
    public async Task<List<cddy_dtl_ddj>> Getcddy_dtl_ddj(BasePageInput input ,string name)
    {
        var entity =  _cddy_dtl_ddj.AsQueryable().Select<cddy_dtl_ddj>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_dtl_ddlj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_dtl_ddlj"), HttpPost]
    public async Task<List<cddy_dtl_ddlj>> Getcddy_dtl_ddlj(BasePageInput input ,string name)
    {
        var entity = _cddy_dtl_ddlj.AsQueryable().Select<cddy_dtl_ddlj>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_dtl_dhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_dtl_dhmk"), HttpPost]
    public async Task<List<cddy_dtl_dhmk>> Getcddy_dtl_dhmk(BasePageInput input ,string name)
    {
        var entity = _cddy_dtl_dhmk.AsQueryable().Select<cddy_dtl_dhmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }

    [DisplayName("获取cddy_dtl_dsmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_dtl_dsmk"), HttpPost]
    public async Task<List<cddy_dtl_dsmk>> Getcddy_dtl_dsmk(BasePageInput input ,string name)
    {
        var entity = _cddy_dtl_dsmk.AsQueryable().Select<cddy_dtl_dsmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }

    [DisplayName("获取cddy_dtl_pgmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_dtl_pgmk"), HttpPost]
    public async Task<List<cddy_dtl_pgmk>> Getcddy_dtl_pgmk(BasePageInput input ,string name)
    {
        var entity = _cddy_dtl_pgmk.AsQueryable().Select<cddy_dtl_pgmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }

    [DisplayName("获取cddy_dtl_rhyk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_dtl_rhyk"), HttpPost]
    public async Task<List<cddy_dtl_rhyk>> Getcddy_dtl_rhyk(BasePageInput input ,string name)
    {
        var entity = _cddy_dtl_rhyk.AsQueryable().Select<cddy_dtl_rhyk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }

    [DisplayName("获取cddy_dtl_xfmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_dtl_xfmk"), HttpPost]
    public async Task<List<cddy_dtl_xfmk>> Getcddy_dtl_xfmk(BasePageInput input ,string name)
    {
        var entity = _cddy_dtl_xfmk.AsQueryable().Select<cddy_dtl_xfmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }

    [DisplayName("获取cddy_dtl_xhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Get"), HttpPost]
    public async Task<List<cddy_dtl_xhmk>> Get(BasePageInput input ,string name)
    {
        var entity = _cddy_dtl_xhmk.AsQueryable().Select<cddy_dtl_xhmk>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
}




