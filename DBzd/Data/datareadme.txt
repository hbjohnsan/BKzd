Bank			银行:ID,Money,Time
Remittance		    :ID,GetTime,Money

Fees			收款:ID,UnitID,PayKind,PlantPrice,TurePrice,Drawee,DraweeTel,Payee,PayTime,Flag,BZ,Year	
-----上级分配的报刊任务-----
Paper			上级总分配报纸:ID,PaperID,YFDH,Name,Number,Price,SubSidy,TotalPrice,TotalSubSidy,IsDanKan,Year
TruePaper		真实刊数：ID,UnitID,P101,P102,P103,P104,P105,P201,P202,P203,P301,P302,TrueMoney,IsOver,Year

*PaperShare	            :ID,UnidID,SharedID,P101,P102,P103,P104,P105,P201,P202,P203,P301,P302,P303,IsOver,Year
PaperTask		报刊任务:ID,UnitId,P101,P102,P103,P104,P105,P201,P202,P203,P301,P302,ComnyMoney,BaseMoney,TotalMoney,Year
	

Receivables		收款:ID,UnitID,PayKind,TrueMoney,PayPeopleId,PayTime,IsOver,BZ,Year

TrueNum			真实定刊数:ID，UnitID,PaperID,TrueNum,Year


Unit			单位：UnitID,AllName,ShortName,Tel,Fax,Kind,Istake,AddressID,IsPay
UnitPost		单位职务：ID,UnitID,UnitPostID,UnitPost,UnitPostTel,PeopleId,Year
Address			通信地址：ID，Twon ,Area
People			人员:PeopleID,UnitID,Name,Sex,HomeTel,Phone,Phone2,QQ,QQ2,Email,CardId,AddressID


Pocket			手中零钱:ID,M50,M20,M10,M5,M1,M05,M01,MTotal
Poster			投递员:ID,PeopleID,AdreeID

－－－－－－－－－－－－－－－－－－－
2015－12－10
设计思路的更改：
1、交款人没有必要记录，原因：1、有时收款人不在场别人代收，无法记录。2、没有必须记录收款人了，因为有的单位让代交。
Receivables		收款:ID,UnitID,PayKind,TrueMoney,PayPeopleId,PayTime,IsOver,BZ,Year
移除PayPeopleId.
----------------------以下为新增学校--------------------------
滦州镇中学
古马镇中学
小马庄镇中学
雷庄镇中学
棒子镇中学
响嘡镇中学
王庄子镇中学
安各庄镇中学
茨榆坨镇中学
古城办中学 
九百户镇中学
杨柳庄镇中学
油榨镇中学
五中
六中
龙山中学
一小
二小
三小
四小
特教
新城幼儿园
私立学校
----------------------------------
2015-12-11
分析：有的单位如教育局，人社局。两个单位有下属单位。在分配任务时针对大的主单位，但在交款时，大单位又把任务分分配给了下载单位。
这时，应如果调整。
在设计数据时Unit单位，设置了两个字段Istake,--是否有任务。IsPay--是否交款单位。
当收款时，要保证，上级总单位的总量，和子单位的报刊量要同部增减。
