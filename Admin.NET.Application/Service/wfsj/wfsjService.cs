// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using Admin.NET.Application.Entity;
namespace Admin.NET.Application.Service.wfsj;

/// <summary>
/// 查询 🧩
/// </summary>
// [AllowAnonymous]
[ApiDescriptionSettings(ApplicationConst.GroupName, Order = 100)]
public class wfsjService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<Entity.wfsj> _wfsj;
    private readonly SqlSugarRepository<wfsj_csmk> _wfsj_csmk;
    private readonly SqlSugarRepository<wfsj_ddjj> _wfsj_ddjj;
    private readonly SqlSugarRepository<wfsj_ddlj> _wfsj_ddlj;
    private readonly SqlSugarRepository<wfsj_dhmk> _wfsj_dhmk;
    private readonly SqlSugarRepository<wfsj_dsmk> _wfsj_dsmk;
    private readonly SqlSugarRepository<wfsj_pgmk> _wfsj_pgmk;
    private readonly SqlSugarRepository<wfsj_rhyk> _wfsj_rhyk;
    private readonly SqlSugarRepository<wfsj_xfmk> _wfsj_xfmk;
    private readonly SqlSugarRepository<wfsj_xhmk> _wfsj_xhmk;

    public wfsjService(SqlSugarRepository<Entity.wfsj> wfsj, SqlSugarRepository<wfsj_csmk> wfsjCsmk, SqlSugarRepository<wfsj_ddjj> wfsjDdjj, SqlSugarRepository<wfsj_ddlj> wfsjDdlj, SqlSugarRepository<wfsj_dhmk> wfsjDhmk, SqlSugarRepository<wfsj_dsmk> wfsjDsmk, SqlSugarRepository<wfsj_pgmk> wfsjPgmk, SqlSugarRepository<wfsj_rhyk> wfsjRhyk, SqlSugarRepository<wfsj_xfmk> wfsjXfmk, SqlSugarRepository<wfsj_xhmk> wfsjXhmk)
    {
        _wfsj = wfsj;
        _wfsj_csmk = wfsjCsmk;
        _wfsj_ddjj = wfsjDdjj;
        _wfsj_ddlj = wfsjDdlj;
        _wfsj_dhmk = wfsjDhmk;
        _wfsj_dsmk = wfsjDsmk;
        _wfsj_pgmk = wfsjPgmk;
        _wfsj_rhyk = wfsjRhyk;
        _wfsj_xfmk = wfsjXfmk;
        _wfsj_xhmk = wfsjXhmk;
    }

    [DisplayName("获取列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getwfsj"), HttpPost]
    public async Task<List<Entity.wfsj>> Getwfsj(BasePageInput input ,string name)
    {
        var list = _wfsj.AsQueryable().Select<Entity.wfsj>();
        return await list.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取wfsj_csmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getwfsj_csmk"), HttpPost]
    public async Task<List<wfsj_csmk>> Getwfsj_csmk(BasePageInput input ,string name)
    {
        var entity = _wfsj_csmk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
        .Select((o ,a) => new wfsj_csmk{
            id = o.id,
            cdbh = o.cdbh,
            cgqlxmc = o.cgqlxmc,
            cdazwz = o.cdazwz,
            cdszdw = a.cgqlx,
            wfpjz = o.wfpjz,
            wfzdz = o.wfzdz,
            wfzdsk = o.wfzdsk,
            wfzxz = o.wfzxz,
            wfzxsk = o.wfzxsk,
            kssj = o.kssj,
            jssj = o.jssj,
            ssk = a.cgqdw
        });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取wfsj_ddjj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getwfsj_ddjj"), HttpPost]
    public async Task<List<wfsj_ddjj>> Getwfsj_ddjj(BasePageInput input ,string name)
    {
        var entity = _wfsj_ddjj.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
        .Select((o, a) => new wfsj_ddjj
        {
            id = o.id,
            cdbh = o.cdbh,
            cgqlxmc = o.cgqlxmc,
            cdazwz = o.cdazwz,
            cdszdw = a.cgqlx,
            wfpjz = o.wfpjz,
            wfzdz = o.wfzdz,
            wfzdsk = o.wfzdsk,
            wfzxz = o.wfzxz,
            wfzxsk = o.wfzxsk,
            kssj = o.kssj,
            jssj = o.jssj,
            ssk = a.cgqdw
        });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取wfsj_ddlj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getwfsj_ddlj"), HttpPost]
    public async Task<List<wfsj_ddlj>> Getwfsj_ddlj(BasePageInput input ,string name)
    {
        var entity = _wfsj_ddlj.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
        .Select((o, a) => new wfsj_ddlj
        {
            id = o.id,
            cdbh = o.cdbh,
            cgqlxmc = o.cgqlxmc,
            cdazwz = o.cdazwz,
            cdszdw = a.cgqlx,
            wfpjz = o.wfpjz,
            wfzdz = o.wfzdz,
            wfzdsk = o.wfzdsk,
            wfzxz = o.wfzxz,
            wfzxsk = o.wfzxsk,
            kssj = o.kssj,
            jssj = o.jssj,
            ssk = a.cgqdw
        });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取wfsj_dhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getwfsj_dhmk"), HttpPost]
    public async Task<List<wfsj_dhmk>> Getwfsj_dhmk(BasePageInput input ,string name)
    {
        var entity = _wfsj_dhmk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
        .Select((o, a) => new wfsj_dhmk
        {
            id = o.id,
            cdbh = o.cdbh,
            cgqlxmc = o.cgqlxmc,
            cdazwz = o.cdazwz,
            cdszdw = a.cgqlx,
            wfpjz = o.wfpjz,
            wfzdz = o.wfzdz,
            wfzdsk = o.wfzdsk,
            wfzxz = o.wfzxz,
            wfzxsk = o.wfzxsk,
            kssj = o.kssj,
            jssj = o.jssj,
            ssk = a.cgqdw
        });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取wfsj_dsmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getwfsj_dsmk"), HttpPost]
    public async Task<List<wfsj_dsmk>> Getwfsj_dsmk(BasePageInput input ,string name, string cgqlxmc)
    {
        var entity = _wfsj_dsmk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
            .Where(o => o.cgqlxmc.Contains(cgqlxmc))
            .Select((o, a) => new wfsj_dsmk
            {
                id = o.id,
                cdbh = o.cdbh,
                cgqlxmc = o.cgqlxmc,
                cdazwz = o.cdazwz,
                cdszdw = a.cgqlx,
                wfpjz = o.wfpjz,
                wfzdz = o.wfzdz,
                wfzdsk = o.wfzdsk,
                wfzxz = o.wfzxz,
                wfzxsk = o.wfzxsk,
                kssj = o.kssj,
                jssj = o.jssj,
                ssk = a.cgqdw
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取wfsj_pgmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getwfsj_pgmk"), HttpPost]
    public async Task<List<wfsj_pgmk>> Getwfsj_pgmk(BasePageInput input ,string name)
    {
        var entity = _wfsj_pgmk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
        .Select((o, a) => new wfsj_pgmk
        {
            id = o.id,
            cdbh = o.cdbh,
            cgqlxmc = o.cgqlxmc,
            cdazwz = o.cdazwz,
            cdszdw = a.cgqlx,
            wfpjz = o.wfpjz,
            wfzdz = o.wfzdz,
            wfzdsk = o.wfzdsk,
            wfzxz = o.wfzxz,
            wfzxsk = o.wfzxsk,
            kssj = o.kssj,
            jssj = o.jssj,
            ssk = a.cgqdw
        });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取wfsj_rhyk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getwfsj_rhyk"), HttpPost]
    public async Task<List<wfsj_rhyk>> Getwfsj_rhyk(BasePageInput input ,string name)
    {
        var entity = _wfsj_rhyk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
        .Select((o, a) => new wfsj_rhyk
        {
            id = o.id,
            cdbh = o.cdbh,
            cgqlxmc = o.cgqlxmc,
            cdazwz = o.cdazwz,
            cdszdw = a.cgqlx,
            wfpjz = o.wfpjz,
            wfzdz = o.wfzdz,
            wfzdsk = o.wfzdsk,
            wfzxz = o.wfzxz,
            wfzxsk = o.wfzxsk,
            kssj = o.kssj,
            jssj = o.jssj,
            ssk = a.cgqdw
        });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取wfsj_xfmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getwfsj_xfmk"), HttpPost]
    public async Task<List<wfsj_xfmk>> Getwfsj_xfmk(BasePageInput input ,string name)
    {
        var entity = _wfsj_xfmk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
        .Select((o, a) => new wfsj_xfmk
        {
            id = o.id,
            cdbh = o.cdbh,
            cgqlxmc = o.cgqlxmc,
            cdazwz = o.cdazwz,
            cdszdw = a.cgqlx,
            wfpjz = o.wfpjz,
            wfzdz = o.wfzdz,
            wfzdsk = o.wfzdsk,
            wfzxz = o.wfzxz,
            wfzxsk = o.wfzxsk,
            kssj = o.kssj,
            jssj = o.jssj,
            ssk = a.cgqdw
        });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取wfsj_xhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getwfsj_xhmk"), HttpPost]
    public async Task<List<wfsj_xhmk>> Getwfsj_xhmk(BasePageInput input ,string name)
    {
        var entity = _wfsj_xhmk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
        .Select((o, a) => new wfsj_xhmk
        {
            id = o.id,
            cdbh = o.cdbh,
            cgqlxmc = o.cgqlxmc,
            cdazwz = o.cdazwz,
            cdszdw = a.cgqlx,
            wfpjz = o.wfpjz,
            wfzdz = o.wfzdz,
            wfzdsk = o.wfzdsk,
            wfzxz = o.wfzxz,
            wfzxsk = o.wfzxsk,
            kssj = o.kssj,
            jssj = o.jssj,
            ssk = a.cgqdw
        });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
}