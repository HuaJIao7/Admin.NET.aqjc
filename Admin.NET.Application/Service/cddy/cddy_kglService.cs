// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using Admin.NET.Application.Entity;
using DocumentFormat.OpenXml.VariantTypes;

namespace Admin.NET.Application.Service.cddy;

/// <summary>
/// 查询cddy_kgl列表 🧩
/// </summary>
[AllowAnonymous]
[ApiDescriptionSettings(ApplicationConst.GroupName, Order = 100)]
public class  cddy_kglService : IDynamicApiController, ITransient
{
    private readonly SqlSugarRepository<cddy_kgl> _cddy_kgl;
    private readonly SqlSugarRepository<cddy_kgl_csmk> _cddy_kgl_csmk;
    private readonly SqlSugarRepository<cddy_kgl_ddjj> _cddy_kgl_ddjj;
    private readonly SqlSugarRepository<cddy_kgl_ddlj> _cddy_kgl_ddlj;
    private readonly SqlSugarRepository<cddy_kgl_dhmk> _cddy_kgl_dhmk;
    private readonly SqlSugarRepository<cddy_kgl_dsmk> _cddy_kgl_dsmk;
    private readonly SqlSugarRepository<cddy_kgl_pgmk> _cddy_kgl_pgmk;
    private readonly SqlSugarRepository<cddy_kgl_rhyk> _cddy_kgl_rhyk;
    private readonly SqlSugarRepository<cddy_kgl_xfmk> _cddy_kgl_xfmk;
    private readonly SqlSugarRepository<cddy_kgl_xhmk> _cddy_kgl_xhmk;
    private readonly SqlSugarRepository<jc_xtlbbm> _jc_xtlbbm;
    private readonly SqlSugarRepository<fzdy_csmk> _fzdy_csmk;
    private readonly SqlSugarRepository<jc_cgqbmb> _jc_cgqbmb;
    private readonly SqlSugarRepository<jc_cgqszlxmb> _jc_cgqszlxmb;
    
    public  cddy_kglService(SqlSugarRepository<Entity.cddy_kgl> cddyKgl, SqlSugarRepository<cddy_kgl_csmk> cddyKglCsmk, SqlSugarRepository<cddy_kgl_ddjj> cddyKglDdjj, SqlSugarRepository<cddy_kgl_ddlj> cddyKglDdlj, SqlSugarRepository<cddy_kgl_dhmk> cddyKglDhmk, SqlSugarRepository<cddy_kgl_dsmk> cddyKglDsmk, SqlSugarRepository<cddy_kgl_pgmk> cddyKglPgmk, SqlSugarRepository<cddy_kgl_rhyk> cddyKglRhyk, SqlSugarRepository<cddy_kgl_xfmk> cddyKglXfmk, SqlSugarRepository<cddy_kgl_xhmk> cddyKglXhmk, SqlSugarRepository<jc_xtlbbm> jcXtlbbm, SqlSugarRepository<fzdy_csmk> fzdyCsmk, SqlSugarRepository<jc_cgqbmb> jcCgqbmb, SqlSugarRepository<jc_cgqszlxmb> jcCgqszlxmb)
    {
        _cddy_kgl = cddyKgl;
        _cddy_kgl_csmk = cddyKglCsmk;
        _cddy_kgl_ddjj = cddyKglDdjj;
        _cddy_kgl_ddlj = cddyKglDdlj;
        _cddy_kgl_dhmk = cddyKglDhmk;
        _cddy_kgl_dsmk = cddyKglDsmk;
        _cddy_kgl_pgmk = cddyKglPgmk;
        _cddy_kgl_rhyk = cddyKglRhyk;
        _cddy_kgl_xfmk = cddyKglXfmk;
        _cddy_kgl_xhmk = cddyKglXhmk;
        _jc_xtlbbm = jcXtlbbm;
        _fzdy_csmk = fzdyCsmk;
        _jc_cgqbmb = jcCgqbmb;
        _jc_cgqszlxmb = jcCgqszlxmb;
    }
    
    [DisplayName("获取cddy_kgl列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_kgl"), HttpPost]
    public async Task<List<Entity.cddy_kgl>> Getcddy_kgl(BasePageInput input ,string name)
    {
        var entity = _cddy_kgl.AsQueryable().Select<Entity.cddy_kgl>();
        return await entity.OrderBuilder(input).ToPageListAsync(input.Page, input.PageSize);
    }
    [DisplayName("获取cddy_kgl_csmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_kgl_csmk"), HttpPost]
    public async Task<List<cddy_kgl_csmk>> Getcddy_kgl_csmk(BasePageInput input ,string name)
    {
        var entity = _cddy_kgl_csmk.AsQueryable()
            .LeftJoin<jc_xtlbbm>((o, a) => o.xtbm == a.bm)//系统类型编码表
            .LeftJoin<jc_cgqbmb>((o, a, b) => o.cgqbm == b.cgqbm)//传感器类型编码表
            .Select((o, a, b) => new cddy_kgl_csmk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = a.bmms,
                fzbm = o.fzbm,
                cgqbm = b.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                kms = o.kms,
                tms = o.tms,
                bjzt = o.bjzt,
                jbzt = o.jbzt,
                ddzt = o.ddzt,
                fdzt = o.fdzt,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });

        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    [DisplayName("获取cddy_kgl_ddjj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_kgl_ddjj"), HttpPost]
    public async Task<List<cddy_kgl_ddjj>> Getcddy_kgl_ddjj(BasePageInput input ,string name)
    {
        var entity = _cddy_kgl_ddjj.AsQueryable()
            .LeftJoin<jc_xtlbbm>((o, a) => o.xtbm == a.bm)//系统类型编码表
            .LeftJoin<jc_cgqbmb>((o, a, b) => o.cgqbm == b.cgqbm)//传感器类型编码表
            .Select((o, a, b) => new cddy_kgl_ddjj
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = a.bmms,
                fzbm = o.fzbm,
                cgqbm = b.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                kms = o.kms,
                tms = o.tms,
                bjzt = o.bjzt,
                jbzt = o.jbzt,
                ddzt = o.ddzt,
                fdzt = o.fdzt,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });

        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    [DisplayName("获取cddy_kgl_ddlj列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_kgl_ddlj"), HttpPost]
    public async Task<List<cddy_kgl_ddlj>> Getcddy_kgl_ddlj(BasePageInput input ,string name)
    {
        var entity = _cddy_kgl_ddlj.AsQueryable()
            .LeftJoin<jc_xtlbbm>((o, a) => o.xtbm == a.bm)//系统类型编码表
            .LeftJoin<jc_cgqbmb>((o, a, b) => o.cgqbm == b.cgqbm)//传感器类型编码表
            .Select((o, a, b) => new cddy_kgl_ddlj
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = a.bmms,
                fzbm = o.fzbm,
                cgqbm = b.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                kms = o.kms,
                tms = o.tms,
                bjzt = o.bjzt,
                jbzt = o.jbzt,
                ddzt = o.ddzt,
                fdzt = o.fdzt,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });

        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    [DisplayName("获取cddy_kgl_dhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_kgl_dhmk"), HttpPost]
    public async Task<List<cddy_kgl_dhmk>> Getcddy_kgl_dhmk(BasePageInput input ,string name)
    {
        var entity = _cddy_kgl_dhmk.AsQueryable()
            .LeftJoin<jc_xtlbbm>((o, a) => o.xtbm == a.bm)//系统类型编码表
            .LeftJoin<jc_cgqbmb>((o, a, b) => o.cgqbm == b.cgqbm)//传感器类型编码表
            .Select((o, a, b) => new cddy_kgl_dhmk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = a.bmms,
                fzbm = o.fzbm,
                cgqbm = b.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                kms = o.kms,
                tms = o.tms,
                bjzt = o.bjzt,
                jbzt = o.jbzt,
                ddzt = o.ddzt,
                fdzt = o.fdzt,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });

        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    [DisplayName("获取cddy_kgl_dsmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_kgl_dsmk"), HttpPost]
    public async Task<List<cddy_kgl_dsmk>> Getcddy_kgl_dsmk(BasePageInput input ,string name)
    {
        var entity = _cddy_kgl_dsmk.AsQueryable()
            .LeftJoin<jc_xtlbbm>((o, a) => o.xtbm == a.bm)//系统类型编码表
            .LeftJoin<jc_cgqbmb>((o, a, b) => o.cgqbm == b.cgqbm)//传感器类型编码表
            .Select((o, a, b) => new cddy_kgl_dsmk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = a.bmms,
                fzbm = o.fzbm,
                cgqbm = b.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                kms = o.kms,
                tms = o.tms,
                bjzt = o.bjzt,
                jbzt = o.jbzt,
                ddzt = o.ddzt,
                fdzt = o.fdzt,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });

        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    [DisplayName("获取cddy_kgl_pgmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_kgl_pgmk"), HttpPost]
    public async Task<List<cddy_kgl_pgmk>> Getcddy_kgl_pgmk(BasePageInput input ,string name)
    {
        var entity = _cddy_kgl_pgmk.AsQueryable()
            .LeftJoin<jc_xtlbbm>((o, a) => o.xtbm == a.bm)//系统类型编码表
            .LeftJoin<jc_cgqbmb>((o, a, b) => o.cgqbm == b.cgqbm)//传感器类型编码表
            .Select((o, a, b) => new cddy_kgl_pgmk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = a.bmms,
                fzbm = o.fzbm,
                cgqbm = b.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                kms = o.kms,
                tms = o.tms,
                bjzt = o.bjzt,
                jbzt = o.jbzt,
                ddzt = o.ddzt,
                fdzt = o.fdzt,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });

        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    [DisplayName("获取cddy_kgl_rhyk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_kgl_rhyk"), HttpPost]
    public async Task<List<cddy_kgl_rhyk>> Getcddy_kgl_rhyk(BasePageInput input ,string name)
    {
        var entity = _cddy_kgl_rhyk.AsQueryable()
            .LeftJoin<jc_xtlbbm>((o, a) => o.xtbm == a.bm)//系统类型编码表
            .LeftJoin<jc_cgqbmb>((o, a, b) => o.cgqbm == b.cgqbm)//传感器类型编码表
            .Select((o, a, b) => new cddy_kgl_rhyk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = a.bmms,
                fzbm = o.fzbm,
                cgqbm = b.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                kms = o.kms,
                tms = o.tms,
                bjzt = o.bjzt,
                jbzt = o.jbzt,
                ddzt = o.ddzt,
                fdzt = o.fdzt,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });

        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    [DisplayName("获取cddy_kgl_xfmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_kgl_xfmk"), HttpPost]
    public async Task<List<cddy_kgl_xfmk>> Getcddy_kgl_xfmk(BasePageInput input ,string name)
    {
        var entity = _cddy_kgl_xfmk.AsQueryable()
            .LeftJoin<jc_xtlbbm>((o, a) => o.xtbm == a.bm)//系统类型编码表
            .LeftJoin<jc_cgqbmb>((o, a, b) => o.cgqbm == b.cgqbm)//传感器类型编码表
            .Select((o, a, b) => new cddy_kgl_xfmk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = a.bmms,
                fzbm = o.fzbm,
                cgqbm = b.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                kms = o.kms,
                tms = o.tms,
                bjzt = o.bjzt,
                jbzt = o.jbzt,
                ddzt = o.ddzt,
                fdzt = o.fdzt,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });

        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
    [DisplayName("获取cddy_kgl_xhmk列表")]
    [AllowAnonymous]
    [ApiDescriptionSettings(Name = "Getcddy_kgl_xhmk"), HttpPost]
    public async Task<List<cddy_kgl_xhmk>> Getcddy_kgl_xhmk(BasePageInput input ,string name)
    {
        var entity = _cddy_kgl_xhmk.AsQueryable()
            .LeftJoin<jc_xtlbbm>((o, a) => o.xtbm == a.bm)//系统类型编码表
            .LeftJoin<jc_cgqbmb>((o, a, b) => o.cgqbm == b.cgqbm)//传感器类型编码表
            .Select((o, a, b) => new cddy_kgl_xhmk
            {
                Id = o.Id,
                cdbm = o.cdbm,
                xtbm = a.bmms,
                fzbm = o.fzbm,
                cgqbm = b.cgqms,
                cdsz = o.cdsz,
                cdmc = o.cdmc,
                cdssqy = o.cdssqy,
                cgqszqy = o.cgqszqy,
                kms = o.kms,
                tms = o.tms,
                bjzt = o.bjzt,
                jbzt = o.jbzt,
                ddzt = o.ddzt,
                fdzt = o.fdzt,
                wzx = o.wzx,
                wzy = o.wzy,
                wzz = o.wzz,
                cgqglgx = o.cgqglgx,
                ssk = o.ssk
            });

        return await entity.ToPageListAsync(input.Page, input.PageSize);
    }
}