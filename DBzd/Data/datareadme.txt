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
王店子镇中学
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
这时，应如何调整？
在设计数据时Unit单位，设置了两个字段Istake,--是否有任务。IsPay--是否交款单位。
当收款时，要保证，上级总单位的总量，和子单位的报刊量要同部增减。

2015-12-17
--------------------
设计：  一是计划任务（分配到各单位任务）总额计算现在的进度。这样，在单位任务中，有任务，交款单位是两个概念了。
	分析：1、任务计划表，不能变。
	      2、收款表。怎么取？
	      3、实际分配任务表怎么设计？
	      4、实际订阅份数怎么设计？
        二是要分类统计出，县直进度，和乡镇进度两项。
        三输出电子表格。
        四是分报项，有的报纸不分。
	五：邮局开票要下明细。

做法：重新设计了Unit单位表。增加了ID，自增片段为主键，和Year年度字段。这样做可以把有更名的单位区分开
      再增加UnitParantTaskID,用于记录该单位的是不是为主单位交款。（此情况一般为，无任务，但要交款的单位）
	如事务局，可以分为本身和县委办，政府办。
        教育局，下分到各镇中心校，及小学。人社局的四家下属单位。
     这样更改表结构的目的：一是分配任务方便。在接到上级总任务后，再本级单位下分给个单位，记录出计划分给各单位的总金额。可以随时掌握当前进度，更真实的反映工作流程。
	二是

(from p in mf.DS.PaperTask.AsEnumerable() where p.Year == year && p.UnitId == unitid select p).SingleOrDefault();
rabYes.Checked = (i.Istake.Equals("是")) ? true : false;
 ur.AddressID = mf.DS.Address.AsEnumerable().Select(t => t.Field<int>("ID")).Max();


 if (!DBNull.Value.Equals(i.AddressID))
                {
                    BKDataSet.AddressRow ar = mf.DS.Address.FindByID(Convert.ToInt32(i.AddressID));
                    combArea.Text = ar.Area;
                    combTwon.Text = ar.Town;
                }

--------------------------------
根据金额查单位 有的单位打款了。需要快速找到他