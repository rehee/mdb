本项目为练习项目
因为做项目的时候, 需要一些灵活的CMS框架. 但是目前流行的框架都多少有点让人不满意的地方.
主要的需求是
1. 非常灵活的ORM. 需要根据客人的需求频繁修改
2. 根据module生成admin
3. 可以自定义admin
4. 部署方便
5. debug 方便

目前想到的一个办法是 .net mvc 加mongodb 对数据这块放弃治疗 全部用json. 尝试一下看行不行.


目前的流程
json <-> c# object <-> Bson <-> mongodb

如果使用默认的bson 序列/反序列 需返回的json于原来的一致. 需要添加ignore attribute

.net mongo driver
https://docs.mongodb.com/ecosystem/drivers/csharp/
win10 mongodb作为服务出错的解决办法
https://yq.aliyun.com/articles/70338

