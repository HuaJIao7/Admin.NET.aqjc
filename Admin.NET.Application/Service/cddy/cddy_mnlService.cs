// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using Admin.NET.Application.Entity;
namespace Admin.NET.Application.Service.cddy;

/// <summary>
/// 查询cddy_mnl列表 🧩
/// </summary>
[AllowAnonymous]
[ApiDescriptionSettings(ApplicationConst.GroupName, Order = 100)]
public class  cddy_mnlService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<cddy_mnl> _cddy_mnl;
    private readonly SqlSugarRepository<cddy_mnl_csmk> _cddy_mnl_csmk;
    private readonly SqlSugarRepository<cddy_mnl_dj > _cddy_mnl_dj;
    private readonly SqlSugarRepository<cddy_mnl_dlj> _cddy_mnl_dlj;
    private readonly SqlSugarRepository<cddy_mnl_dhmk> _cddy_mnl_dhmk;
    private readonly SqlSugarRepository<cddy_mnl_dsmk> _cddy_mnl_dsmk;
    private readonly SqlSugarRepository<cddy_mnl_pgmk> _cddy_mnl_pgmk;
    private readonly SqlSugarRepository<cddy_mnl_rhyk> _cddy_mnl_rhyk;
    private readonly SqlSugarRepository<cddy_mnl_xfmk> _cddy_mnl_xfmk;
    private readonly SqlSugarRepository<cddy_mnl_xhmk> _cddy_mnl_xhmk;
    
    public  cddy_mnlService(SqlSugarRepository<Entity.cddy_mnl> cddyMnl, SqlSugarRepository<cddy_mnl_csmk> cddyMnlCsmk, SqlSugarRepository<cddy_mnl_dj> cddyMnlDj, SqlSugarRepository<cddy_mnl_dlj> cddyMnlDlj, SqlSugarRepository<cddy_mnl_dhmk> cddyMnlDhmk, SqlSugarRepository<cddy_mnl_dsmk> cddyMnlDsmk, SqlSugarRepository<cddy_mnl_pgmk> cddyMnlPgmk, SqlSugarRepository<cddy_mnl_rhyk> cddyMnlRhyk, SqlSugarRepository<cddy_mnl_xfmk> cddyMnlXfmk, SqlSugarRepository<cddy_mnl_xhmk> cddyMnlXhmk)
    {
        _cddy_mnl = cddyMnl;
        _cddy_mnl_csmk = cddyMnlCsmk;
        _cddy_mnl_dj = cddyMnlDj;
        _cddy_mnl_dlj = cddyMnlDlj;
        _cddy_mnl_dhmk = cddyMnlDhmk;
        _cddy_mnl_dsmk = cddyMnlDsmk;
        _cddy_mnl_pgmk = cddyMnlPgmk;
        _cddy_mnl_rhyk = cddyMnlRhyk;
        _cddy_mnl_xfmk = cddyMnlXfmk;
        _cddy_mnl_xhmk = cddyMnlXhmk;
    }
    
    //[DisplayName("获取cddy_mnl列表")]
    //[AllowAnonymous]
    //[ApiDescriptionSettings(Name = "Getcddy_mnl"), HttpPost]
    //public async Task<List<cddy_mnl>> Getcddy_mnl(BasePageInput input ,string name)
    //{
    //    var entity = _cddy_mnl.AsQueryable().Select<cddy_mnl>();
    //    return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    //}
    
    [DisplayName("获取cddy_mnl列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_mnl"), HttpPost]
    public async Task<List<cddy_mnl>> Get(BasePageInput input ,string name)
    {
        var entity = _cddy_mnl.AsQueryable()
            .LeftJoin<jc_cgqbmb>((o, a) => o.cgqbm == a.cgqbm)
            .Select((o,a) => new cddy_mnl
            {
                Id = o.Id,
                xtbm = o.xtbm,
                fzbm = o.fzbm,
                cgqbm = a.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                cdzdw = o.cdzdw,
                glc = o.glc,
                dlc = o.dlc,
                sxbjmx = o.sxbjmx,
                sxjbmx = o.sxjbmx,
                xxbjmx = o.xxbjmx,
                xxjbmx = o.xxjbmx,
                sxddmx = o.sxddmx,
                sxfdmx = o.sxfdmx,
                xxddmx = o.xxddmx,
                xxfdmx = o.xxfdmx,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_mnl_csmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_mnl_csmk"), HttpPost]
    public async Task<List<cddy_mnl_csmk>> Getcddy_mnl_csmk(BasePageInput input ,string name)
    {
        var entity = _cddy_mnl_csmk.AsQueryable()
            .LeftJoin<jc_cgqbmb>((o, a) => o.cgqbm == a.cgqbm)
            .Select((o,a) => new cddy_mnl_csmk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = o.xtbm,
                fzbm = o.fzbm,
                cgqbm = a.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                cdzdw = o.cdzdw,
                glc = o.glc,
                dlc = o.dlc,
                sxbjmx = o.sxbjmx,
                sxjbmx = o.sxjbmx,
                xxbjmx = o.xxbjmx,
                xxjbmx = o.xxjbmx,
                sxddmx = o.sxddmx,
                sxfdmx = o.sxfdmx,
                xxddmx = o.xxddmx,
                xxfdmx = o.xxfdmx,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_mnl_dj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_mnl_dj"), HttpPost]
    public async Task<List<cddy_mnl_dj>> Getcddy_mnl_dj(BasePageInput input ,string name)
    {
        var entity = _cddy_mnl_dj.AsQueryable()
            .LeftJoin<jc_cgqbmb>((o, a) => o.cgqbm == a.cgqbm)
            .Select((o,a) => new cddy_mnl_dj
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = o.xtbm,
                fzbm = o.fzbm,
                cgqbm = a.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                cdzdw = o.cdzdw,
                glc = o.glc,
                dlc = o.dlc,
                sxbjmx = o.sxbjmx,
                sxjbmx = o.sxjbmx,
                xxbjmx = o.xxbjmx,
                xxjbmx = o.xxjbmx,
                sxddmx = o.sxddmx,
                sxfdmx = o.sxfdmx,
                xxddmx = o.xxddmx,
                xxfdmx = o.xxfdmx,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_mnl_dlj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_mnl_dlj"), HttpPost]
    public async Task<List<cddy_mnl_dlj>> Getcddy_mnl_dlj(BasePageInput input ,string name)
    {
        var entity = _cddy_mnl_dlj.AsQueryable()
            .LeftJoin<jc_cgqbmb>((o, a) => o.cgqbm == a.cgqbm)
            .Select((o,a) => new cddy_mnl_dlj
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = o.xtbm,
                fzbm = o.fzbm,
                cgqbm = a.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                cdzdw = o.cdzdw,
                glc = o.glc,
                dlc = o.dlc,
                sxbjmx = o.sxbjmx,
                sxjbmx = o.sxjbmx,
                xxbjmx = o.xxbjmx,
                xxjbmx = o.xxjbmx,
                sxddmx = o.sxddmx,
                sxfdmx = o.sxfdmx,
                xxddmx = o.xxddmx,
                xxfdmx = o.xxfdmx,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_mnl_dhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_mnl_dhmk"), HttpPost]
    public async Task<List<cddy_mnl_dhmk>> Getcddy_mnl_dhmk(BasePageInput input ,string name)
    {
        var entity = _cddy_mnl_dhmk.AsQueryable()
            .LeftJoin<jc_cgqbmb>((o, a) => o.cgqbm == a.cgqbm)
            .Select((o,a) => new cddy_mnl_dhmk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = o.xtbm,
                fzbm = o.fzbm,
                cgqbm = a.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                cdzdw = o.cdzdw,
                glc = o.glc,
                dlc = o.dlc,
                sxbjmx = o.sxbjmx,
                sxjbmx = o.sxjbmx,
                xxbjmx = o.xxbjmx,
                xxjbmx = o.xxjbmx,
                sxddmx = o.sxddmx,
                sxfdmx = o.sxfdmx,
                xxddmx = o.xxddmx,
                xxfdmx = o.xxfdmx,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_mnl_dsmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_mnl_dsmk"), HttpPost]
    public async Task<List<cddy_mnl_dsmk>> Getcddy_mnl_dsmk(BasePageInput input ,string name)
    {
        var entity = _cddy_mnl_dsmk.AsQueryable()
            .LeftJoin<jc_cgqbmb>((o, a) => o.cgqbm == a.cgqbm)
            .Select((o,a) => new cddy_mnl_dsmk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = o.xtbm,
                fzbm = o.fzbm,
                cgqbm = a.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                cdzdw = o.cdzdw,
                glc = o.glc,
                dlc = o.dlc,
                sxbjmx = o.sxbjmx,
                sxjbmx = o.sxjbmx,
                xxbjmx = o.xxbjmx,
                xxjbmx = o.xxjbmx,
                sxddmx = o.sxddmx,
                sxfdmx = o.sxfdmx,
                xxddmx = o.xxddmx,
                xxfdmx = o.xxfdmx,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_mnl_pgmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_mnl_pgmk"), HttpPost]
    public async Task<List<cddy_mnl_pgmk>> Getcddy_mnl_pgmk(BasePageInput input ,string name)
    {
        var entity = _cddy_mnl_pgmk.AsQueryable()
            .LeftJoin<jc_cgqbmb>((o, a) => o.cgqbm == a.cgqbm)
            .Select((o,a) => new cddy_mnl_pgmk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = o.xtbm,
                fzbm = o.fzbm,
                cgqbm = a.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                cdzdw = o.cdzdw,
                glc = o.glc,
                dlc = o.dlc,
                sxbjmx = o.sxbjmx,
                sxjbmx = o.sxjbmx,
                xxbjmx = o.xxbjmx,
                xxjbmx = o.xxjbmx,
                sxddmx = o.sxddmx,
                sxfdmx = o.sxfdmx,
                xxddmx = o.xxddmx,
                xxfdmx = o.xxfdmx,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_mnl_rhyk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_mnl_rhyk"), HttpPost]
    public async Task<List<cddy_mnl_rhyk>> Getcddy_mnl_rhyk(BasePageInput input ,string name)
    {
        var entity = _cddy_mnl_rhyk.AsQueryable()
            .LeftJoin<jc_cgqbmb>((o, a) => o.cgqbm == a.cgqbm)
            .Select((o,a) => new cddy_mnl_rhyk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = o.xtbm,
                fzbm = o.fzbm,
                cgqbm = a.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                cdzdw = o.cdzdw,
                glc = o.glc,
                dlc = o.dlc,
                sxbjmx = o.sxbjmx,
                sxjbmx = o.sxjbmx,
                xxbjmx = o.xxbjmx,
                xxjbmx = o.xxjbmx,
                sxddmx = o.sxddmx,
                sxfdmx = o.sxfdmx,
                xxddmx = o.xxddmx,
                xxfdmx = o.xxfdmx,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_mnl_xfmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_mnl_xfmk"), HttpPost]
    public async Task<List<cddy_mnl_xfmk>> Getcddy_mnl_xfmk(BasePageInput input ,string name)
    {
        var entity = _cddy_mnl_xfmk.AsQueryable()
            .LeftJoin<jc_cgqbmb>((o, a) => o.cgqbm == a.cgqbm)
            .Select((o,a) => new cddy_mnl_xfmk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = o.xtbm,
                fzbm = o.fzbm,
                cgqbm = a.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                cdzdw = o.cdzdw,
                glc = o.glc,
                dlc = o.dlc,
                sxbjmx = o.sxbjmx,
                sxjbmx = o.sxjbmx,
                xxbjmx = o.xxbjmx,
                xxjbmx = o.xxjbmx,
                sxddmx = o.sxddmx,
                sxfdmx = o.sxfdmx,
                xxddmx = o.xxddmx,
                xxfdmx = o.xxfdmx,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取cddy_mnl_xhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_mnl_xhmk"), HttpPost]
    public async Task<List<cddy_mnl_xhmk>> Getcddy_mnl_xhmk(BasePageInput input ,string name)
    {
        var entity = _cddy_mnl_xhmk.AsQueryable()
            .LeftJoin<jc_cgqbmb>((o, a) => o.cgqbm == a.cgqbm)
            .Select((o,a) => new cddy_mnl_xhmk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = o.xtbm,
                fzbm = o.fzbm,
                cgqbm = a.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                cdzdw = o.cdzdw,
                glc = o.glc,
                dlc = o.dlc,
                sxbjmx = o.sxbjmx,
                sxjbmx = o.sxjbmx,
                xxbjmx = o.xxbjmx,
                xxjbmx = o.xxjbmx,
                sxddmx = o.sxddmx,
                sxfdmx = o.sxfdmx,
                xxddmx = o.xxddmx,
                xxfdmx = o.xxfdmx,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
}