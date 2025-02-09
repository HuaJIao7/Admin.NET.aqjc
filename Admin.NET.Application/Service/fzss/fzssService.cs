// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using Admin.NET.Application.Service.fzss.Dto;

using Admin.NET.Application.Entity;
namespace Admin.NET.Application.Service.fzss;

/// <summary>
/// 查询 🧩
/// </summary>
// [AllowAnonymous]
[ApiDescriptionSettings(ApplicationConst.GroupName, Order = 100)]
public class fzssService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<Entity.fzss> _fzss;
    private readonly SqlSugarRepository<fzss_csmk> _fzss_csmk;
    private readonly SqlSugarRepository<fzss_ddjj> _fzss_ddjj;
    private readonly SqlSugarRepository<fzss_ddlj> _fzss_ddlj;
    private readonly SqlSugarRepository<fzss_dhmk> _fzss_dhmk;
    private readonly SqlSugarRepository<fzss_dsmk> _fzss_dsmk;
    private readonly SqlSugarRepository<fzss_pgmk> _fzss_pgmk;
    private readonly SqlSugarRepository<fzss_rhyk> _fzss_rhyk;
    private readonly SqlSugarRepository<fzss_xfmk> _fzss_xfmk;
    private readonly SqlSugarRepository<fzss_xhmk> _fzss_xhmk;
    
    public fzssService(SqlSugarRepository<Entity.fzss> fzss, SqlSugarRepository<fzss_csmk> fzssCsmk, SqlSugarRepository<fzss_ddjj> fzssDdjj, SqlSugarRepository<fzss_ddlj> fzssDdlj, SqlSugarRepository<fzss_dhmk> fzssDhmk, SqlSugarRepository<fzss_dsmk> fzssDsmk, SqlSugarRepository<fzss_pgmk> fzssPgmk, SqlSugarRepository<fzss_rhyk> fzssRhyk, SqlSugarRepository<fzss_xfmk> fzssXfmk, SqlSugarRepository<fzss_xhmk> fzssXhmk)
    {
        _fzss = fzss;
        _fzss_csmk = fzssCsmk;
        _fzss_ddjj = fzssDdjj;
        _fzss_ddlj = fzssDdlj;
        _fzss_dhmk = fzssDhmk;
        _fzss_dsmk = fzssDsmk;
        _fzss_pgmk = fzssPgmk;
        _fzss_rhyk = fzssRhyk;
        _fzss_xfmk = fzssXfmk;
        _fzss_xhmk = fzssXhmk;
    }

    [DisplayName("获取列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzss"), HttpPost]
    public async Task<List<Entity.fzss>> Getfzss(BasePageInput input ,string name)
    {
        var list = _fzss.AsQueryable().Select<Entity.fzss>();
        return await list.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzss_csmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzss_csmk"), HttpPost]
    public async Task<List<fzss_csmk>> Getfzss_csmk(BasePageInput input ,string name)
    {
        var entity = _fzss_csmk.AsQueryable()
            .LeftJoin<jc_fzgdzt>((a, b) => a.fzgdzt == b.bm)
            .LeftJoin<jc_fzyxzt>((a, b, c) => a.fzyxzt == c.bm)
            .Select((a, b, c) => new fzss_csmk
            {
                Id = a.Id,
                fzbm = a.fzbm,
                fzyxzt = c.bmms,
                fzgdzt = b.bmms,
                sjsj = a.sjsj,
                ssk = a.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzss_ddjj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzss_ddjj"), HttpPost]
    public async Task<List<fzss_ddjj>> Getfzss_ddjj(BasePageInput input ,string name)
    {
        var entity = _fzss_ddjj.AsQueryable()
            .LeftJoin<jc_fzgdzt>((a, b) => a.fzgdzt == b.bm)
            .LeftJoin<jc_fzyxzt>((a, b, c) => a.fzyxzt == c.bm)
            .Select((a, b, c) => new fzss_ddjj
            {
                Id = a.Id,
                fzbm = a.fzbm,
                fzyxzt = c.bmms,
                fzgdzt = b.bmms,
                sjsj = a.sjsj,
                ssk = a.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzss_ddlj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzss_ddlj"), HttpPost]
    public async Task<List<fzss_ddlj>> Getfzss_ddlj(BasePageInput input ,string name)
    {
        var entity = _fzss_ddlj.AsQueryable()
            .LeftJoin<jc_fzgdzt>((a, b) => a.fzgdzt == b.bm)
            .LeftJoin<jc_fzyxzt>((a, b, c) => a.fzyxzt == c.bm)
            .Select((a, b, c) => new fzss_ddlj
            {
                Id = a.Id,
                fzbm = a.fzbm,
                fzyxzt = c.bmms,
                fzgdzt = b.bmms,
                sjsj = a.sjsj,
                ssk = a.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzss_dhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzss_dhmk"), HttpPost]
    public async Task<List<fzss_dhmk>> Getfzss_dhmk(BasePageInput input ,string name)
    {
        var entity = _fzss_dhmk.AsQueryable()
            .LeftJoin<jc_fzgdzt>((a, b) => a.fzgdzt == b.bm)
            .LeftJoin<jc_fzyxzt>((a, b, c) => a.fzyxzt == c.bm)
            .Select((a, b, c) => new fzss_dhmk
            {
                Id = a.Id,
                fzbm = a.fzbm,
                fzyxzt = c.bmms,
                fzgdzt = b.bmms,
                sjsj = a.sjsj,
                ssk = a.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzss_dsmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzss_dsmk"), HttpPost]
    public async Task<List<fzss_dsmk>> Getfzss_dsmk(BasePageInput input ,string name)
    {
        var entity = _fzss_dsmk.AsQueryable()
            .LeftJoin<jc_fzgdzt>((a, b) => a.fzgdzt == b.bm)
            .LeftJoin<jc_fzyxzt>((a, b, c) => a.fzyxzt == c.bm)
            .Select((a, b, c) => new fzss_dsmk
            {
                Id = a.Id,
                fzbm = a.fzbm,
                fzyxzt = c.bmms,
                fzgdzt = b.bmms,
                sjsj = a.sjsj,
                ssk = a.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzss_pgmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzss_pgmk"), HttpPost]
    public async Task<List<fzss_pgmk>> Getfzss_pgmk(BasePageInput input ,string name)
    {
        var entity = _fzss_pgmk.AsQueryable()
            .LeftJoin<jc_fzgdzt>((a, b) => a.fzgdzt == b.bm)
            .LeftJoin<jc_fzyxzt>((a, b, c) => a.fzyxzt == c.bm)
            .Select((a, b, c) => new fzss_pgmk
            {
                Id = a.Id,
                fzbm = a.fzbm,
                fzyxzt = c.bmms,
                fzgdzt = b.bmms,
                sjsj = a.sjsj,
                ssk = a.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzss_rhyk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzss_rhyk"), HttpPost]
    public async Task<List<fzss_rhyk>> Getfzss_rhyk(BasePageInput input ,string name)
    {
        var entity = _fzss_rhyk.AsQueryable()
            .LeftJoin<jc_fzgdzt>((a, b) => a.fzgdzt == b.bm)
            .LeftJoin<jc_fzyxzt>((a, b, c) => a.fzyxzt == c.bm)
            .Select((a, b, c) => new fzss_rhyk
            {
                Id = a.Id,
                fzbm = a.fzbm,
                fzyxzt = c.bmms,
                fzgdzt = b.bmms,
                sjsj = a.sjsj,
                ssk = a.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzss_xfmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzss_xfmk"), HttpPost]
    public async Task<List<fzss_xfmk>> Getfzss_xfmk(BasePageInput input ,string name)
    {
        var entity = _fzss_xfmk.AsQueryable()
            .LeftJoin<jc_fzgdzt>((a, b) => a.fzgdzt == b.bm)
            .LeftJoin<jc_fzyxzt>((a, b, c) => a.fzyxzt == c.bm)
            .Select((a, b, c) => new fzss_xfmk
            {
                Id = a.Id,
                fzbm = a.fzbm,
                fzyxzt = c.bmms,
                fzgdzt = b.bmms,
                sjsj = a.sjsj,
                ssk = a.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    
    [DisplayName("获取fzss_xhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getfzss_xhmk"), HttpPost]
    public async Task<List<fzss_xhmk>> Getfzss_xhmk(BasePageInput input ,string name)
    {
        var entity = _fzss_xhmk.AsQueryable()
            .LeftJoin<jc_fzgdzt>((a, b) => a.fzgdzt == b.bm)
            .LeftJoin<jc_fzyxzt>((a, b, c) => a.fzyxzt == c.bm)
            .Select((a, b, c) => new fzss_xhmk
            {
                Id = a.Id,
                fzbm = a.fzbm,
                fzyxzt = c.bmms,
                fzgdzt = b.bmms,
                sjsj = a.sjsj,
                ssk = a.ssk
            });
        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
}