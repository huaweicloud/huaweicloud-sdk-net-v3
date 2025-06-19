using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TmssTestcase 
    {

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("activity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 应用产品
        /// </summary>
        [JsonProperty("applied_product", NullValueHandling = NullValueHandling.Ignore)]
        public string AppliedProduct { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// 自动化类型
        /// </summary>
        [JsonProperty("auto_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoType { get; set; }

        /// <summary>
        /// 用例分类ID
        /// </summary>
        [JsonProperty("cataId", NullValueHandling = NullValueHandling.Ignore)]
        public string CataId { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonProperty("creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_1", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_10", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField10 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_11", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField11 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_12", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField12 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_13", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField13 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_14", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField14 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_15", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField15 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_16", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField16 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_17", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField17 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_18", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField18 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_19", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField19 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_2", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_20", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField20 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_21", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField21 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_22", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField22 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_23", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField23 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_24", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField24 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_25", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField25 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_3", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_4", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_5", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_6", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_7", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField7 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_8", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField8 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_field_9", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField9 { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// dr关系ID
        /// </summary>
        [JsonProperty("dr_relationid", NullValueHandling = NullValueHandling.Ignore)]
        public string DrRelationid { get; set; }

        /// <summary>
        /// 环境类型
        /// </summary>
        [JsonProperty("env_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvType { get; set; }

        /// <summary>
        /// 执行平台
        /// </summary>
        [JsonProperty("exe_platform", NullValueHandling = NullValueHandling.Ignore)]
        public string ExePlatform { get; set; }

        /// <summary>
        /// 内部预期输出
        /// </summary>
        [JsonProperty("expect_output", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectOutput { get; set; }

        /// <summary>
        /// 特性路径
        /// </summary>
        [JsonProperty("feature_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FeaturePath { get; set; }

        /// <summary>
        /// 是否为关键字
        /// </summary>
        [JsonProperty("isKeyWord", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsKeyWord { get; set; }

        /// <summary>
        /// 是否为合同测试用例
        /// </summary>
        [JsonProperty("is_contract_testcase", NullValueHandling = NullValueHandling.Ignore)]
        public string IsContractTestcase { get; set; }

        /// <summary>
        /// 是否为参数校验测试用例
        /// </summary>
        [JsonProperty("is_paraValidator_testcase", NullValueHandling = NullValueHandling.Ignore)]
        public string IsParaValidatorTestcase { get; set; }

        /// <summary>
        /// 标签ID列表
        /// </summary>
        [JsonProperty("labelId", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LabelId { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModified { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [JsonProperty("last_modifier", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifier { get; set; }

        /// <summary>
        /// 最后的结果
        /// </summary>
        [JsonProperty("last_result", NullValueHandling = NullValueHandling.Ignore)]
        public string LastResult { get; set; }

        /// <summary>
        /// 用例级别
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// 市场
        /// </summary>
        [JsonProperty("market", NullValueHandling = NullValueHandling.Ignore)]
        public string Market { get; set; }

        /// <summary>
        /// 模块ID
        /// </summary>
        [JsonProperty("moduleId", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 公共aw和项目的关联关系
        /// </summary>
        [JsonProperty("networkScriptName", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkScriptName { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// 用例编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 原始的uri
        /// </summary>
        [JsonProperty("originUri", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginUri { get; set; }

        /// <summary>
        /// 测试的所有者
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 所有者ID
        /// </summary>
        [JsonProperty("ownerId", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerId { get; set; }

        /// <summary>
        /// 测试前置条件
        /// </summary>
        [JsonProperty("preparation", NullValueHandling = NullValueHandling.Ignore)]
        public string Preparation { get; set; }

        /// <summary>
        /// 新服务新建用例版本号
        /// </summary>
        [JsonProperty("releaseDev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 发布ID
        /// </summary>
        [JsonProperty("releaseId", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        /// 阶段
        /// </summary>
        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public string Stage { get; set; }

        /// <summary>
        /// 存储测试步骤和预期结果值对象
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<TmssStep> Steps { get; set; }

        /// <summary>
        /// 脚本路径
        /// </summary>
        [JsonProperty("svnScriptPath", NullValueHandling = NullValueHandling.Ignore)]
        public string SvnScriptPath { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 测试特性
        /// </summary>
        [JsonProperty("test_feature", NullValueHandling = NullValueHandling.Ignore)]
        public string TestFeature { get; set; }

        /// <summary>
        /// 内部测试步骤
        /// </summary>
        [JsonProperty("test_step", NullValueHandling = NullValueHandling.Ignore)]
        public string TestStep { get; set; }

        /// <summary>
        /// 测试类型
        /// </summary>
        [JsonProperty("test_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestType { get; set; }

        /// <summary>
        /// 用例基线Uri(BAM 接口覆盖率迭代下用例信息获取用)
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmssTestcase {\n");
            sb.Append("  activityId: ").Append(ActivityId).Append("\n");
            sb.Append("  appliedProduct: ").Append(AppliedProduct).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  autoType: ").Append(AutoType).Append("\n");
            sb.Append("  cataId: ").Append(CataId).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  customField1: ").Append(CustomField1).Append("\n");
            sb.Append("  customField10: ").Append(CustomField10).Append("\n");
            sb.Append("  customField11: ").Append(CustomField11).Append("\n");
            sb.Append("  customField12: ").Append(CustomField12).Append("\n");
            sb.Append("  customField13: ").Append(CustomField13).Append("\n");
            sb.Append("  customField14: ").Append(CustomField14).Append("\n");
            sb.Append("  customField15: ").Append(CustomField15).Append("\n");
            sb.Append("  customField16: ").Append(CustomField16).Append("\n");
            sb.Append("  customField17: ").Append(CustomField17).Append("\n");
            sb.Append("  customField18: ").Append(CustomField18).Append("\n");
            sb.Append("  customField19: ").Append(CustomField19).Append("\n");
            sb.Append("  customField2: ").Append(CustomField2).Append("\n");
            sb.Append("  customField20: ").Append(CustomField20).Append("\n");
            sb.Append("  customField21: ").Append(CustomField21).Append("\n");
            sb.Append("  customField22: ").Append(CustomField22).Append("\n");
            sb.Append("  customField23: ").Append(CustomField23).Append("\n");
            sb.Append("  customField24: ").Append(CustomField24).Append("\n");
            sb.Append("  customField25: ").Append(CustomField25).Append("\n");
            sb.Append("  customField3: ").Append(CustomField3).Append("\n");
            sb.Append("  customField4: ").Append(CustomField4).Append("\n");
            sb.Append("  customField5: ").Append(CustomField5).Append("\n");
            sb.Append("  customField6: ").Append(CustomField6).Append("\n");
            sb.Append("  customField7: ").Append(CustomField7).Append("\n");
            sb.Append("  customField8: ").Append(CustomField8).Append("\n");
            sb.Append("  customField9: ").Append(CustomField9).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  drRelationid: ").Append(DrRelationid).Append("\n");
            sb.Append("  envType: ").Append(EnvType).Append("\n");
            sb.Append("  exePlatform: ").Append(ExePlatform).Append("\n");
            sb.Append("  expectOutput: ").Append(ExpectOutput).Append("\n");
            sb.Append("  featurePath: ").Append(FeaturePath).Append("\n");
            sb.Append("  isKeyWord: ").Append(IsKeyWord).Append("\n");
            sb.Append("  isContractTestcase: ").Append(IsContractTestcase).Append("\n");
            sb.Append("  isParaValidatorTestcase: ").Append(IsParaValidatorTestcase).Append("\n");
            sb.Append("  labelId: ").Append(LabelId).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("  lastModifier: ").Append(LastModifier).Append("\n");
            sb.Append("  lastResult: ").Append(LastResult).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  market: ").Append(Market).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  networkScriptName: ").Append(NetworkScriptName).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  originUri: ").Append(OriginUri).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  ownerId: ").Append(OwnerId).Append("\n");
            sb.Append("  preparation: ").Append(Preparation).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  releaseId: ").Append(ReleaseId).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("  stage: ").Append(Stage).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  svnScriptPath: ").Append(SvnScriptPath).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  testFeature: ").Append(TestFeature).Append("\n");
            sb.Append("  testStep: ").Append(TestStep).Append("\n");
            sb.Append("  testType: ").Append(TestType).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TmssTestcase);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TmssTestcase input)
        {
            if (input == null) return false;
            if (this.ActivityId != input.ActivityId || (this.ActivityId != null && !this.ActivityId.Equals(input.ActivityId))) return false;
            if (this.AppliedProduct != input.AppliedProduct || (this.AppliedProduct != null && !this.AppliedProduct.Equals(input.AppliedProduct))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.AutoType != input.AutoType || (this.AutoType != null && !this.AutoType.Equals(input.AutoType))) return false;
            if (this.CataId != input.CataId || (this.CataId != null && !this.CataId.Equals(input.CataId))) return false;
            if (this.CreationDate != input.CreationDate || (this.CreationDate != null && !this.CreationDate.Equals(input.CreationDate))) return false;
            if (this.CustomField1 != input.CustomField1 || (this.CustomField1 != null && !this.CustomField1.Equals(input.CustomField1))) return false;
            if (this.CustomField10 != input.CustomField10 || (this.CustomField10 != null && !this.CustomField10.Equals(input.CustomField10))) return false;
            if (this.CustomField11 != input.CustomField11 || (this.CustomField11 != null && !this.CustomField11.Equals(input.CustomField11))) return false;
            if (this.CustomField12 != input.CustomField12 || (this.CustomField12 != null && !this.CustomField12.Equals(input.CustomField12))) return false;
            if (this.CustomField13 != input.CustomField13 || (this.CustomField13 != null && !this.CustomField13.Equals(input.CustomField13))) return false;
            if (this.CustomField14 != input.CustomField14 || (this.CustomField14 != null && !this.CustomField14.Equals(input.CustomField14))) return false;
            if (this.CustomField15 != input.CustomField15 || (this.CustomField15 != null && !this.CustomField15.Equals(input.CustomField15))) return false;
            if (this.CustomField16 != input.CustomField16 || (this.CustomField16 != null && !this.CustomField16.Equals(input.CustomField16))) return false;
            if (this.CustomField17 != input.CustomField17 || (this.CustomField17 != null && !this.CustomField17.Equals(input.CustomField17))) return false;
            if (this.CustomField18 != input.CustomField18 || (this.CustomField18 != null && !this.CustomField18.Equals(input.CustomField18))) return false;
            if (this.CustomField19 != input.CustomField19 || (this.CustomField19 != null && !this.CustomField19.Equals(input.CustomField19))) return false;
            if (this.CustomField2 != input.CustomField2 || (this.CustomField2 != null && !this.CustomField2.Equals(input.CustomField2))) return false;
            if (this.CustomField20 != input.CustomField20 || (this.CustomField20 != null && !this.CustomField20.Equals(input.CustomField20))) return false;
            if (this.CustomField21 != input.CustomField21 || (this.CustomField21 != null && !this.CustomField21.Equals(input.CustomField21))) return false;
            if (this.CustomField22 != input.CustomField22 || (this.CustomField22 != null && !this.CustomField22.Equals(input.CustomField22))) return false;
            if (this.CustomField23 != input.CustomField23 || (this.CustomField23 != null && !this.CustomField23.Equals(input.CustomField23))) return false;
            if (this.CustomField24 != input.CustomField24 || (this.CustomField24 != null && !this.CustomField24.Equals(input.CustomField24))) return false;
            if (this.CustomField25 != input.CustomField25 || (this.CustomField25 != null && !this.CustomField25.Equals(input.CustomField25))) return false;
            if (this.CustomField3 != input.CustomField3 || (this.CustomField3 != null && !this.CustomField3.Equals(input.CustomField3))) return false;
            if (this.CustomField4 != input.CustomField4 || (this.CustomField4 != null && !this.CustomField4.Equals(input.CustomField4))) return false;
            if (this.CustomField5 != input.CustomField5 || (this.CustomField5 != null && !this.CustomField5.Equals(input.CustomField5))) return false;
            if (this.CustomField6 != input.CustomField6 || (this.CustomField6 != null && !this.CustomField6.Equals(input.CustomField6))) return false;
            if (this.CustomField7 != input.CustomField7 || (this.CustomField7 != null && !this.CustomField7.Equals(input.CustomField7))) return false;
            if (this.CustomField8 != input.CustomField8 || (this.CustomField8 != null && !this.CustomField8.Equals(input.CustomField8))) return false;
            if (this.CustomField9 != input.CustomField9 || (this.CustomField9 != null && !this.CustomField9.Equals(input.CustomField9))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DrRelationid != input.DrRelationid || (this.DrRelationid != null && !this.DrRelationid.Equals(input.DrRelationid))) return false;
            if (this.EnvType != input.EnvType || (this.EnvType != null && !this.EnvType.Equals(input.EnvType))) return false;
            if (this.ExePlatform != input.ExePlatform || (this.ExePlatform != null && !this.ExePlatform.Equals(input.ExePlatform))) return false;
            if (this.ExpectOutput != input.ExpectOutput || (this.ExpectOutput != null && !this.ExpectOutput.Equals(input.ExpectOutput))) return false;
            if (this.FeaturePath != input.FeaturePath || (this.FeaturePath != null && !this.FeaturePath.Equals(input.FeaturePath))) return false;
            if (this.IsKeyWord != input.IsKeyWord || (this.IsKeyWord != null && !this.IsKeyWord.Equals(input.IsKeyWord))) return false;
            if (this.IsContractTestcase != input.IsContractTestcase || (this.IsContractTestcase != null && !this.IsContractTestcase.Equals(input.IsContractTestcase))) return false;
            if (this.IsParaValidatorTestcase != input.IsParaValidatorTestcase || (this.IsParaValidatorTestcase != null && !this.IsParaValidatorTestcase.Equals(input.IsParaValidatorTestcase))) return false;
            if (this.LabelId != input.LabelId || (this.LabelId != null && input.LabelId != null && !this.LabelId.SequenceEqual(input.LabelId))) return false;
            if (this.LastModified != input.LastModified || (this.LastModified != null && !this.LastModified.Equals(input.LastModified))) return false;
            if (this.LastModifier != input.LastModifier || (this.LastModifier != null && !this.LastModifier.Equals(input.LastModifier))) return false;
            if (this.LastResult != input.LastResult || (this.LastResult != null && !this.LastResult.Equals(input.LastResult))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Market != input.Market || (this.Market != null && !this.Market.Equals(input.Market))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NetworkScriptName != input.NetworkScriptName || (this.NetworkScriptName != null && !this.NetworkScriptName.Equals(input.NetworkScriptName))) return false;
            if (this.NodeName != input.NodeName || (this.NodeName != null && !this.NodeName.Equals(input.NodeName))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.OriginUri != input.OriginUri || (this.OriginUri != null && !this.OriginUri.Equals(input.OriginUri))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.OwnerId != input.OwnerId || (this.OwnerId != null && !this.OwnerId.Equals(input.OwnerId))) return false;
            if (this.Preparation != input.Preparation || (this.Preparation != null && !this.Preparation.Equals(input.Preparation))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.ReleaseId != input.ReleaseId || (this.ReleaseId != null && !this.ReleaseId.Equals(input.ReleaseId))) return false;
            if (this.Remark != input.Remark || (this.Remark != null && !this.Remark.Equals(input.Remark))) return false;
            if (this.Stage != input.Stage || (this.Stage != null && !this.Stage.Equals(input.Stage))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && input.Steps != null && !this.Steps.SequenceEqual(input.Steps))) return false;
            if (this.SvnScriptPath != input.SvnScriptPath || (this.SvnScriptPath != null && !this.SvnScriptPath.Equals(input.SvnScriptPath))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;
            if (this.TestFeature != input.TestFeature || (this.TestFeature != null && !this.TestFeature.Equals(input.TestFeature))) return false;
            if (this.TestStep != input.TestStep || (this.TestStep != null && !this.TestStep.Equals(input.TestStep))) return false;
            if (this.TestType != input.TestType || (this.TestType != null && !this.TestType.Equals(input.TestType))) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.ActivityId != null) hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.AppliedProduct != null) hashCode = hashCode * 59 + this.AppliedProduct.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.AutoType != null) hashCode = hashCode * 59 + this.AutoType.GetHashCode();
                if (this.CataId != null) hashCode = hashCode * 59 + this.CataId.GetHashCode();
                if (this.CreationDate != null) hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.CustomField1 != null) hashCode = hashCode * 59 + this.CustomField1.GetHashCode();
                if (this.CustomField10 != null) hashCode = hashCode * 59 + this.CustomField10.GetHashCode();
                if (this.CustomField11 != null) hashCode = hashCode * 59 + this.CustomField11.GetHashCode();
                if (this.CustomField12 != null) hashCode = hashCode * 59 + this.CustomField12.GetHashCode();
                if (this.CustomField13 != null) hashCode = hashCode * 59 + this.CustomField13.GetHashCode();
                if (this.CustomField14 != null) hashCode = hashCode * 59 + this.CustomField14.GetHashCode();
                if (this.CustomField15 != null) hashCode = hashCode * 59 + this.CustomField15.GetHashCode();
                if (this.CustomField16 != null) hashCode = hashCode * 59 + this.CustomField16.GetHashCode();
                if (this.CustomField17 != null) hashCode = hashCode * 59 + this.CustomField17.GetHashCode();
                if (this.CustomField18 != null) hashCode = hashCode * 59 + this.CustomField18.GetHashCode();
                if (this.CustomField19 != null) hashCode = hashCode * 59 + this.CustomField19.GetHashCode();
                if (this.CustomField2 != null) hashCode = hashCode * 59 + this.CustomField2.GetHashCode();
                if (this.CustomField20 != null) hashCode = hashCode * 59 + this.CustomField20.GetHashCode();
                if (this.CustomField21 != null) hashCode = hashCode * 59 + this.CustomField21.GetHashCode();
                if (this.CustomField22 != null) hashCode = hashCode * 59 + this.CustomField22.GetHashCode();
                if (this.CustomField23 != null) hashCode = hashCode * 59 + this.CustomField23.GetHashCode();
                if (this.CustomField24 != null) hashCode = hashCode * 59 + this.CustomField24.GetHashCode();
                if (this.CustomField25 != null) hashCode = hashCode * 59 + this.CustomField25.GetHashCode();
                if (this.CustomField3 != null) hashCode = hashCode * 59 + this.CustomField3.GetHashCode();
                if (this.CustomField4 != null) hashCode = hashCode * 59 + this.CustomField4.GetHashCode();
                if (this.CustomField5 != null) hashCode = hashCode * 59 + this.CustomField5.GetHashCode();
                if (this.CustomField6 != null) hashCode = hashCode * 59 + this.CustomField6.GetHashCode();
                if (this.CustomField7 != null) hashCode = hashCode * 59 + this.CustomField7.GetHashCode();
                if (this.CustomField8 != null) hashCode = hashCode * 59 + this.CustomField8.GetHashCode();
                if (this.CustomField9 != null) hashCode = hashCode * 59 + this.CustomField9.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DrRelationid != null) hashCode = hashCode * 59 + this.DrRelationid.GetHashCode();
                if (this.EnvType != null) hashCode = hashCode * 59 + this.EnvType.GetHashCode();
                if (this.ExePlatform != null) hashCode = hashCode * 59 + this.ExePlatform.GetHashCode();
                if (this.ExpectOutput != null) hashCode = hashCode * 59 + this.ExpectOutput.GetHashCode();
                if (this.FeaturePath != null) hashCode = hashCode * 59 + this.FeaturePath.GetHashCode();
                if (this.IsKeyWord != null) hashCode = hashCode * 59 + this.IsKeyWord.GetHashCode();
                if (this.IsContractTestcase != null) hashCode = hashCode * 59 + this.IsContractTestcase.GetHashCode();
                if (this.IsParaValidatorTestcase != null) hashCode = hashCode * 59 + this.IsParaValidatorTestcase.GetHashCode();
                if (this.LabelId != null) hashCode = hashCode * 59 + this.LabelId.GetHashCode();
                if (this.LastModified != null) hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifier != null) hashCode = hashCode * 59 + this.LastModifier.GetHashCode();
                if (this.LastResult != null) hashCode = hashCode * 59 + this.LastResult.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Market != null) hashCode = hashCode * 59 + this.Market.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkScriptName != null) hashCode = hashCode * 59 + this.NetworkScriptName.GetHashCode();
                if (this.NodeName != null) hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.OriginUri != null) hashCode = hashCode * 59 + this.OriginUri.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.OwnerId != null) hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.Preparation != null) hashCode = hashCode * 59 + this.Preparation.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.ReleaseId != null) hashCode = hashCode * 59 + this.ReleaseId.GetHashCode();
                if (this.Remark != null) hashCode = hashCode * 59 + this.Remark.GetHashCode();
                if (this.Stage != null) hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.SvnScriptPath != null) hashCode = hashCode * 59 + this.SvnScriptPath.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TestFeature != null) hashCode = hashCode * 59 + this.TestFeature.GetHashCode();
                if (this.TestStep != null) hashCode = hashCode * 59 + this.TestStep.GetHashCode();
                if (this.TestType != null) hashCode = hashCode * 59 + this.TestType.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                return hashCode;
            }
        }
    }
}
