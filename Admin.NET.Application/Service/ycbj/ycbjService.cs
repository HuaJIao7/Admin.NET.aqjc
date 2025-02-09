// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using Admin.NET.Application.Entity;
namespace Admin.NET.Application.Service.ycbj;

/// <summary>
/// 查询 🧩
/// </summary>
// [AllowAnonymous]
[ApiDescriptionSettings(ApplicationConst.GroupName, Order = 100)]
public class ycbjService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<Entity.ycbj> _ycbj;
    private readonly SqlSugarRepository<ycbj_csmk> _ycbj_csmk;
    private readonly SqlSugarRepository<ycbj_ddjj> _ycbj_ddjj;
    private readonly SqlSugarRepository<ycbj_ddlj> _ycbj_ddlj;
    private readonly SqlSugarRepository<ycbj_dhmk> _ycbj_dhmk;
    private readonly SqlSugarRepository<ycbj_dsmk> _ycbj_dsmk;
    private readonly SqlSugarRepository<ycbj_pgmk> _ycbj_pgmk;
    private readonly SqlSugarRepository<ycbj_rhyk> _ycbj_rhyk;
    private readonly SqlSugarRepository<ycbj_xfmk> _ycbj_xfmk;
    private readonly SqlSugarRepository<ycbj_xhmk> _ycbj_xhmk;

    public ycbjService(SqlSugarRepository<Entity.ycbj> ycbj, SqlSugarRepository<ycbj_csmk> ycbjCsmk, SqlSugarRepository<ycbj_ddjj> ycbjDdjj, SqlSugarRepository<ycbj_ddlj> ycbjDdlj, SqlSugarRepository<ycbj_dhmk> ycbjDhmk, SqlSugarRepository<ycbj_dsmk> ycbjDsmk, SqlSugarRepository<ycbj_pgmk> ycbjPgmk, SqlSugarRepository<ycbj_rhyk> ycbjRhyk, SqlSugarRepository<ycbj_xfmk> ycbjXfmk, SqlSugarRepository<ycbj_xhmk> ycbjXhmk)
    {
        _ycbj = ycbj;
        _ycbj_csmk = ycbjCsmk;
        _ycbj_ddjj = ycbjDdjj;
        _ycbj_ddlj = ycbjDdlj;
        _ycbj_dhmk = ycbjDhmk;
        _ycbj_dsmk = ycbjDsmk;
        _ycbj_pgmk = ycbjPgmk;
        _ycbj_rhyk = ycbjRhyk;
        _ycbj_xfmk = ycbjXfmk;
        _ycbj_xhmk = ycbjXhmk;
    }

    [DisplayName("获取列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getycbj"), HttpPost]
    public async Task<List<Entity.ycbj>> Getycbj(BasePageInput input ,string name)
    {
        var list = _ycbj.AsQueryable().Select<Entity.ycbj>();
        return await list.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取ycbj_csmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getycbj_csmk"), HttpPost]
    public async Task<List<ycbj_csmk>> Getycbj_csmk(BasePageInput input ,string name)
    {
        var entity = _ycbj_csmk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
            .LeftJoin<jc_bjyclxb>((o, a, b) => o.yclx == b.bjbm)
            .Select((o ,a ,b) => new ycbj_csmk{
                Id = o.Id,
                cdbh = o.cdbh,
                cgqlxmc = o.cgqlxmc,
                cdazwz = o.cdazwz,
                cdszdw = a.cgqlx,
                yclx = b.bjms,
                cddqz = o.cddqz,
                bjmx = o.bjmx,
                jbmx = o.jbmx,
                ycqssk = o.ycqssk,
                ycqjzdz = o.ycqjzdz,
                zdzsk = o.zdzsk,
                zxzsk = o.zxzsk,
                ycqjpjz = o.ycqjpjz,
                ycqjzxz = o.ycqjzxz,
                ycyy = o.ycyy,
                clcs = o.clcs,
                lrsj = o.lrsj,
                lrr = o.lrr,
                sjsj = o.sjsj,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取ycbj_ddjj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getycbj_ddjj"), HttpPost]
    public async Task<List<ycbj_ddjj>> Getycbj_ddjj(BasePageInput input ,string name)
    {
        var entity = _ycbj_ddjj.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
            .LeftJoin<jc_bjyclxb>((o, a, b) => o.yclx == b.bjbm)
            .Select((o, a, b) => new ycbj_ddjj
            {
                Id = o.Id,
                cdbh = o.cdbh,
                cgqlxmc = o.cgqlxmc,
                cdazwz = o.cdazwz,
                cdszdw = a.cgqlx,
                yclx = b.bjms,
                cddqz = o.cddqz,
                bjmx = o.bjmx,
                jbmx = o.jbmx,
                ycqssk = o.ycqssk,
                ycqjzdz = o.ycqjzdz,
                zdzsk = o.zdzsk,
                zxzsk = o.zxzsk,
                ycqjpjz = o.ycqjpjz,
                ycqjzxz = o.ycqjzxz,
                ycyy = o.ycyy,
                clcs = o.clcs,
                lrsj = o.lrsj,
                lrr = o.lrr,
                sjsj = o.sjsj,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取ycbj_ddlj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getycbj_ddlj"), HttpPost]
    public async Task<List<ycbj_ddlj>> Getycbj_ddlj(BasePageInput input ,string name)
    {
        var entity = _ycbj_ddlj.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
            .LeftJoin<jc_bjyclxb>((o, a, b) => o.yclx == b.bjbm)
            .Select((o, a, b) => new ycbj_ddlj
            {
                Id = o.Id,
                cdbh = o.cdbh,
                cgqlxmc = o.cgqlxmc,
                cdazwz = o.cdazwz,
                cdszdw = a.cgqlx,
                yclx = b.bjms,
                cddqz = o.cddqz,
                bjmx = o.bjmx,
                jbmx = o.jbmx,
                ycqssk = o.ycqssk,
                ycqjzdz = o.ycqjzdz,
                zdzsk = o.zdzsk,
                zxzsk = o.zxzsk,
                ycqjpjz = o.ycqjpjz,
                ycqjzxz = o.ycqjzxz,
                ycyy = o.ycyy,
                clcs = o.clcs,
                lrsj = o.lrsj,
                lrr = o.lrr,
                sjsj = o.sjsj,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取ycbj_dhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getycbj_dhmk"), HttpPost]
    public async Task<List<ycbj_dhmk>> Getycbj_dhmk(BasePageInput input ,string name)
    {
        var entity = _ycbj_dhmk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
            .LeftJoin<jc_bjyclxb>((o, a, b) => o.yclx == b.bjbm)
            .Select((o, a, b) => new ycbj_dhmk
            {
                Id = o.Id,
                cdbh = o.cdbh,
                cgqlxmc = o.cgqlxmc,
                cdazwz = o.cdazwz,
                cdszdw = a.cgqlx,
                yclx = b.bjms,
                cddqz = o.cddqz,
                bjmx = o.bjmx,
                jbmx = o.jbmx,
                ycqssk = o.ycqssk,
                ycqjzdz = o.ycqjzdz,
                zdzsk = o.zdzsk,
                zxzsk = o.zxzsk,
                ycqjpjz = o.ycqjpjz,
                ycqjzxz = o.ycqjzxz,
                ycyy = o.ycyy,
                clcs = o.clcs,
                lrsj = o.lrsj,
                lrr = o.lrr,
                sjsj = o.sjsj,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取ycbj_dsmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getycbj_dsmk"), HttpPost]
    public async Task<List<ycbj_dsmk>> Getycbj_dsmk(BasePageInput input ,string name)
    {
        var entity = _ycbj_dsmk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
            .LeftJoin<jc_bjyclxb>((o, a, b) => o.yclx == b.bjbm)
            .Select((o, a, b) => new ycbj_dsmk
            {
                Id = o.Id,
                cdbh = o.cdbh,
                cgqlxmc = o.cgqlxmc,
                cdazwz = o.cdazwz,
                cdszdw = a.cgqlx,
                yclx = b.bjms,
                cddqz = o.cddqz,
                bjmx = o.bjmx,
                jbmx = o.jbmx,
                ycqssk = o.ycqssk,
                ycqjzdz = o.ycqjzdz,
                zdzsk = o.zdzsk,
                zxzsk = o.zxzsk,
                ycqjpjz = o.ycqjpjz,
                ycqjzxz = o.ycqjzxz,
                ycyy = o.ycyy,
                clcs = o.clcs,
                lrsj = o.lrsj,
                lrr = o.lrr,
                sjsj = o.sjsj,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取ycbj_pgmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getycbj_pgmk"), HttpPost]
    public async Task<List<ycbj_pgmk>> Getycbj_pgmk(BasePageInput input ,string name)
    {
        var entity = _ycbj_pgmk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
            .LeftJoin<jc_bjyclxb>((o, a, b) => o.yclx == b.bjbm)
            .Select((o, a, b) => new ycbj_pgmk
            {
                Id = o.Id,
                cdbh = o.cdbh,
                cgqlxmc = o.cgqlxmc,
                cdazwz = o.cdazwz,
                cdszdw = a.cgqlx,
                yclx = b.bjms,
                cddqz = o.cddqz,
                bjmx = o.bjmx,
                jbmx = o.jbmx,
                ycqssk = o.ycqssk,
                ycqjzdz = o.ycqjzdz,
                zdzsk = o.zdzsk,
                zxzsk = o.zxzsk,
                ycqjpjz = o.ycqjpjz,
                ycqjzxz = o.ycqjzxz,
                ycyy = o.ycyy,
                clcs = o.clcs,
                lrsj = o.lrsj,
                lrr = o.lrr,
                sjsj = o.sjsj,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取ycbj_rhyk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getycbj_rhyk"), HttpPost]
    public async Task<List<ycbj_rhyk>> Getycbj_rhyk(BasePageInput input ,string name)
    {
        var entity = _ycbj_rhyk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
            .LeftJoin<jc_bjyclxb>((o, a, b) => o.yclx == b.bjbm)
            .Select((o, a, b) => new ycbj_rhyk
            {
                Id = o.Id,
                cdbh = o.cdbh,
                cgqlxmc = o.cgqlxmc,
                cdazwz = o.cdazwz,
                cdszdw = a.cgqlx,
                yclx = b.bjms,
                cddqz = o.cddqz,
                bjmx = o.bjmx,
                jbmx = o.jbmx,
                ycqssk = o.ycqssk,
                ycqjzdz = o.ycqjzdz,
                zdzsk = o.zdzsk,
                zxzsk = o.zxzsk,
                ycqjpjz = o.ycqjpjz,
                ycqjzxz = o.ycqjzxz,
                ycyy = o.ycyy,
                clcs = o.clcs,
                lrsj = o.lrsj,
                lrr = o.lrr,
                sjsj = o.sjsj,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取ycbj_xfmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getycbj_xfmk"), HttpPost]
    public async Task<List<ycbj_xfmk>> Getycbj_xfmk(BasePageInput input ,string name)
    {
        var entity = _ycbj_xfmk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
            .LeftJoin<jc_bjyclxb>((o, a, b) => o.yclx == b.bjbm)
            .Select((o, a, b) => new ycbj_xfmk
            {
                Id = o.Id,
                cdbh = o.cdbh,
                cgqlxmc = o.cgqlxmc,
                cdazwz = o.cdazwz,
                cdszdw = a.cgqlx,
                yclx = b.bjms,
                cddqz = o.cddqz,
                bjmx = o.bjmx,
                jbmx = o.jbmx,
                ycqssk = o.ycqssk,
                ycqjzdz = o.ycqjzdz,
                zdzsk = o.zdzsk,
                zxzsk = o.zxzsk,
                ycqjpjz = o.ycqjpjz,
                ycqjzxz = o.ycqjzxz,
                ycyy = o.ycyy,
                clcs = o.clcs,
                lrsj = o.lrsj,
                lrr = o.lrr,
                sjsj = o.sjsj,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取ycbj_xhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getycbj_xhmk"), HttpPost]
    public async Task<List<ycbj_xhmk>> Getycbj_xhmk(BasePageInput input ,string name)
    {
        var entity = _ycbj_xhmk.AsQueryable()
            .LeftJoin<jc_cgqdw>((o, a) => o.cdszdw == a.cgqdw)
            .LeftJoin<jc_bjyclxb>((o, a, b) => o.yclx == b.bjbm)
            .Select((o, a, b) => new ycbj_xhmk
            {
                Id = o.Id,
                cdbh = o.cdbh,
                cgqlxmc = o.cgqlxmc,
                cdazwz = o.cdazwz,
                cdszdw = a.cgqlx,
                yclx = b.bjms,
                cddqz = o.cddqz,
                bjmx = o.bjmx,
                jbmx = o.jbmx,
                ycqssk = o.ycqssk,
                ycqjzdz = o.ycqjzdz,
                zdzsk = o.zdzsk,
                zxzsk = o.zxzsk,
                ycqjpjz = o.ycqjpjz,
                ycqjzxz = o.ycqjzxz,
                ycyy = o.ycyy,
                clcs = o.clcs,
                lrsj = o.lrsj,
                lrr = o.lrr,
                sjsj = o.sjsj,
                ssk = o.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
}