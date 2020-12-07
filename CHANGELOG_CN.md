## 3.0.24-beta 2020-12-04
## HuaweiCloud SDK SMN
 - ### 新增特性
    - 支持消息通知服务
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无


## 3.0.23-beta 2020-11-30
## HuaweiCloud SDK BMS
 - ### 新增特性
    - 支持裸金属服务器
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK BSS
 - ### 新增特性
    - 新增支持接口：查询使用量列表，设置/取消包周期资源到期转按需
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK CBR
 - ### 新增特性
    - 新增支持接口：迁移资源接口
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK CES
 - ### 新增特性
    - 新增支持接口：
     - 查询事件监控列表
     - 查询某一个事件监控详情
     - 创建资源分组
     - 更新资源分组
     - 删除资源分组
     - 查询所有资源分组
     - 修改告警规则
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK ECS
 - ### 新增特性
    - 无
 - ### 解决问题
    - 无
 - ### 特性变更
    - [Issue 21](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/21) 开放查询SSH密钥详情接口

## HuaweiCloud SDK IAM
 - ### 新增特性
    - 新增支持接口
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无


## 3.0.22-beta 2020-11-17
## HuaweiCloud SDK DMS
 - ### 新增特性
    - 无
 - ### 解决问题
    - 无
 - ### 特性变更
    - 属性类型调整：属性 `创建队列的时间` 由 `string` 类型调整为 `integer64` 类型

## HuaweiCloud SDK ECS
 - ### 新增特性
    - 无
 - ### 解决问题
    - 无
 - ### 特性变更
    - 创建虚拟机接口（按需和包周期）增加 `dry_run` 属性，表示是否预检此次请求

## HuaweiCloud SDK NAT
 - ### 新增特性
    - 支持NAT网关服务
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK Kafka
 - ### 新增特性
    - 无
 - ### 解决问题
    - 无
 - ### 特性变更
    - 接口名调整：UpdateInstanceCrossVPCIP → UpdateInstanceCrossVpcIp

## HuaweiCloud SDK VPC
 - ### 新增特性
    - 支持网络ACL相关接口
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无


## 3.0.21-beta 2020-11-11
## HuaweiCloud SDK CBR
 - ### 新增特性
    - 无
 - ### 解决问题
    - 无
 - ### 特性变更
    - 创建存储库接口(CreateVault)新增存储库turbo类型
    - 修改策略接口(UpdatePolicy)删除多余字段

## HuaweiCloud SDK CES
 - ### 新增特性
    - 新增接口响应示例，调整字段描述
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无


## 3.0.20-beta 2020-11-02
## HuaweiCloud SDK CES
 - ### 新增特性
    - 无
 - ### 解决问题
    - 无
 - ### 特性变更
    - 创建告警规则接口增加资源分组字段
    - 查询告警历史接口响应体metadata修改，只返回total字段

## HuaweiCloud SDK ELB
 - ### 新增特性
    - 无
 - ### 解决问题
    - 创建转发规则接口参数名错误问题修复
 - ### 特性变更
    - 无


## 3.0.19-beta 2020-10-31
## HuaweiCloud SDK CBR
 - ### 新增特性
    - 新增支持接口：TAG标签相关接口
 - ### 解决问题
    - [Issue 17](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/17) 修复ListBackups接口响应体问题
 - ### 特性变更
    - 无

## HuaweiCloud SDK CTS
 - ### 新增特性
    - 新增支持接口：ListQuotas（查询租户追踪器配额信息）
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK Iam
 - ### 新增特性
    - 无
 - ### 解决问题
    - 无
 - ### 特性变更
    - 接口名称调整，涉及接口：
     1. KeystoneCreateUserTokenByPasswordAndMFA → KeystoneCreateUserTokenByPasswordAndMfa
     2. CreateUnscopeTokenByIDPInitiated → CreateUnscopeTokenByIdpInitiated

## HuaweiCloud SDK ProjectMan
 - ### 新增特性
    - 新增支持接口：迭代信息、用户信息、项目成员、项目信息、项目指标、项目统计等相关方法的接口
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无


## 3.0.18-beta 2020-10-20
## HuaweiCloud SDK DCS
 - ### 新增特性
    - 无
 - ### 解决问题
    - 无
 - ### 特性变更
    - 接口名中去掉冗余的Dcs服务名

## HuaweiCloud SDK ELB
 - ### 新增特性
    - 支持弹性负载均衡服务
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK IoTDA
 - ### 新增特性
    - 增加规则相关接口
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无


## 3.0.17-beta 2020-10-14
## HuaweiCloud SDK BSS
 - ### 新增特性
    - 伙伴中心支持导出产品目录价
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK DCS
 - ### 新增特性
    - 增加支持接口
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无


## 3.0.16-beta 2020-10-12
## HuaweiCloud SDK CTS
 - ### 新增特性
    - 无
 - ### 解决问题
    - 无
 - ### 特性变更
    - 删除v1版本废弃接口


## 3.0.15-beta 2020-09-30
## Huaweicloud SDK Core
 - ### 新增特性
    - 无
 - ### 解决问题
    - 修复整型枚举类型在发起请求时传值类型错误的问题
 - ### 特性变更
    - 无

## HuaweiCloud SDK CBR
 - ### 新增特性
    - 支持云备份服务
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## Huaweicloud SDK EIP
 - ### 新增特性
    - 支持弹性公网IP服务
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无


## 3.0.14-beta 2020-09-24
## HuaweiCloud SDK BSS
 - ### 新增特性
    - 无
 - ### 解决问题
    - 修复BssClient类无法加载的问题
 - ### 特性变更
    - 无


## 3.0.13-beta 2020-09-16
## HuaweiCloud SDK ECS
 - ### 新增特性
    - 无
 - ### 解决问题
    - 修正接口参数类型
 - ### 特性变更
    - 无

## HuaweiCloud SDK BSS
 - ### 新增特性
    - 无
 - ### 解决问题
    - 无
 - ### 特性变更
    - 运营能力开放接口更新


# 3.0.12-beta 2020-09-11


# 3.0.11-beta 2020-09-09
## HuaweiCloud SDK Core
 - ### 新增特性
    - 无
 - ### 解决问题
    - 删除代码仓中的冗余Sidecar代码
 - ### 特性变更
    - 无

## HuaweiCloud SDK DMS
 - ### 新增特性
    - 支持分布式消息服务，提供Kafka专享版和RabbitMQ专享版
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK VPC
 - ### 新增特性
    - 无
 - ### 解决问题
    - 修复安全组相关接口类型错误的问题
 - ### 特性变更
    - 无


# 3.0.10-beta 2020-09-04
## HuaweiCloud SDK Core
 - ### 新增特性
    - 无
 - ### 解决问题
    - 修复yaml中没有定义format的整型枚举参数无法生成枚举代码的问题
 - ### 特性变更
    - 调整Http请求头的User-Agent信息


# 3.0.9-beta 2020-08-28
## HuaweiCloud SDK EVS
 - ### 新增特性
    - 无
 - ### 解决问题
    - ListVolumesByTags接口，修改total_count类型定义错误的问题
 - ### 特性变更
    - 无

## HuaweiCloud SDK IAM
 - ### 新增特性
    - 新增支持接口：console一致性相关接口
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK IoTDA
 - ### 新增特性
    - 新增支持接口：批量操作接口和异步接口
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK ProjectMan
 - ### 新增特性
    - 支持项目管理服务
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK VPC
 - ### 新增特性
    - 新增支持接口：安全组、安全组规则和可用IP数
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无


# 3.0.8-beta 2020-8-14
## HuaweiCloud SDK Core
 - ### 新增特性
    - 支持临时AK/SK认证模式
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK BSS
 - ### 新增特性
    - 支持运营能力开放服务
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## HuaweiCloud SDK KMS
 - ### 新增特性
    - 支持密钥管理服务
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无


# __3.0.7-beta__ __2020-07-30__
## __HuaweiCloud SDK Core__
 - ### 新增特性
    - 支持文件上传下载
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无

## __HuaweiCloud SDK ECS__
 - ### 新增特性
    - 发布新接口，如变更操作系统/重置密码
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无
    
## __HuaweiCloud SDK VPC__
 - ### 新增特性
    - 支持VPC v3版本的接口
 - ### 解决问题
    - 无
 - ### 特性变更
    - 无


# __3.0.6-beta__ __2020-07-15__
## __HuaweiCloud SDK EVS__
 - ### 新增特性
    - 无
 - ### 解决问题
    - [Issue #3](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/3)：获取单个磁盘详情接口报错问题修复
 - ### 特性变更
    - 无

## __HuaweiCloud SDK IAM__
  - ### 新增特性
     - 无
  - ### 解决问题
     - 修复keystoneListVersions响应体解析失败问题
  - ### 特性变更
     - 无

## __HuaweiCloud SDK IoTDA__
 - ### 新增特性
    - 无
 - ### 解决问题
    - 无
 - ### 特性变更
    - 支持资源空间相关接口

     
# __3.0.5-beta__ __2020-06-30__
## __HuaweiCloud SDK Core__
  - ### 新增特性
    - 异步客户端
    - 问题定位场景自定义请求日志输出
  - ### 解决问题
    - 无
  - ### 特性变更
    - 无

## __HuaweiCloud SDK CTS__
  - ### 新增特性
    - 支持云审计服务
  - ### 解决问题
    - 无
  - ### 特性变更
    - 无
     
## __HuaweiCloud SDK EVS__
  - ### 新增特性
    - 无
  - ### 解决问题
    - 无
  - ### 特性变更
    - 支持全量服务接口
            
## __HuaweiCloud SDK IoTDA__
  - ### 新增特性
    - 支持设备接入服务
  - ### 解决问题
    - 无
  - ### 特性变更
    - 无
    
