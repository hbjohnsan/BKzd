Bank			����:ID,Money,Time
Remittance		    :ID,GetTime,Money

Fees			�տ�:ID,UnitID,PayKind,PlantPrice,TurePrice,Drawee,DraweeTel,Payee,PayTime,Flag,BZ,Year	
-----�ϼ�����ı�������-----
Paper			�ϼ��ܷ��䱨ֽ:ID,PaperID,YFDH,Name,Number,Price,SubSidy,TotalPrice,TotalSubSidy,IsDanKan,Year
TruePaper		��ʵ������ID,UnitID,P101,P102,P103,P104,P105,P201,P202,P203,P301,P302,TrueMoney,IsOver,Year

*PaperShare	            :ID,UnidID,SharedID,P101,P102,P103,P104,P105,P201,P202,P203,P301,P302,P303,IsOver,Year
PaperTask		��������:ID,UnitId,P101,P102,P103,P104,P105,P201,P202,P203,P301,P302,ComnyMoney,BaseMoney,TotalMoney,Year
	

Receivables		�տ�:ID,UnitID,PayKind,TrueMoney,PayPeopleId,PayTime,IsOver,BZ,Year

TrueNum			��ʵ������:ID��UnitID,PaperID,TrueNum,Year


Unit			��λ��UnitID,AllName,ShortName,Tel,Fax,Kind,Istake,AddressID,IsPay
UnitPost		��λְ��ID,UnitID,UnitPostID,UnitPost,UnitPostTel,PeopleId,Year
Address			ͨ�ŵ�ַ��ID��Twon ,Area
People			��Ա:PeopleID,UnitID,Name,Sex,HomeTel,Phone,Phone2,QQ,QQ2,Email,CardId,AddressID


Pocket			������Ǯ:ID,M50,M20,M10,M5,M1,M05,M01,MTotal
Poster			Ͷ��Ա:ID,PeopleID,AdreeID

��������������������������������������
2015��12��10
���˼·�ĸ��ģ�
1��������û�б�Ҫ��¼��ԭ��1����ʱ�տ��˲��ڳ����˴��գ��޷���¼��2��û�б����¼�տ����ˣ���Ϊ�еĵ�λ�ô�����
Receivables		�տ�:ID,UnitID,PayKind,TrueMoney,PayPeopleId,PayTime,IsOver,BZ,Year
�Ƴ�PayPeopleId.
----------------------����Ϊ����ѧУ--------------------------
��������ѧ
��������ѧ
С��ׯ����ѧ
��ׯ����ѧ
��������ѧ
��R����ѧ
����������ѧ
����ׯ����ѧ
����������ѧ
�ųǰ���ѧ 
�Űٻ�����ѧ
����ׯ����ѧ
��ե����ѧ
����
����
��ɽ��ѧ
һС
��С
��С
��С
�ؽ�
�³��׶�԰
˽��ѧУ
----------------------------------
2015-12-11
�������еĵ�λ������֣�����֡�������λ��������λ���ڷ�������ʱ��Դ������λ�����ڽ���ʱ����λ�ְ�����ַ���������ص�λ��
��ʱ��Ӧ��ε�����
���������ʱUnit��λ�������������ֶ�Istake,--�Ƿ�������IsPay--�Ƿ񽻿λ��
���տ�ʱ��Ҫ��֤���ϼ��ܵ�λ�����������ӵ�λ�ı�����Ҫͬ��������

2015-12-17
--------------------
��ƣ�  һ�Ǽƻ����񣨷��䵽����λ�����ܶ�������ڵĽ��ȡ��������ڵ�λ�����У������񣬽��λ�����������ˡ�
	������1������ƻ������ܱ䡣
	      2���տ����ôȡ��
	      3��ʵ�ʷ����������ô��ƣ�
	      4��ʵ�ʶ��ķ�����ô��ƣ�
        ����Ҫ����ͳ�Ƴ�����ֱ���ȣ�������������
        ��������ӱ��
        ���Ƿֱ���еı�ֽ���֡�
	�壺�ʾֿ�ƱҪ����ϸ��

���������������Unit��λ��������ID������Ƭ��Ϊ��������Year����ֶΡ����������԰��и����ĵ�λ���ֿ�
      ������UnitParantTaskID,���ڼ�¼�õ�λ���ǲ���Ϊ����λ����������һ��Ϊ�������񣬵�Ҫ����ĵ�λ��
	������֣����Է�Ϊ�������ί�죬�����졣
        �����֣��·ֵ���������У����Сѧ������ֵ��ļ�������λ��
     �������ı�ṹ��Ŀ�ģ�һ�Ƿ������񷽱㡣�ڽӵ��ϼ���������ٱ�����λ�·ָ�����λ����¼���ƻ��ָ�����λ���ܽ�������ʱ���յ�ǰ���ȣ�����ʵ�ķ�ӳ�������̡�
	����

(from p in mf.DS.PaperTask.AsEnumerable() where p.Year == year && p.UnitId == unitid select p).SingleOrDefault();
rabYes.Checked = (i.Istake.Equals("��")) ? true : false;
 ur.AddressID = mf.DS.Address.AsEnumerable().Select(t => t.Field<int>("ID")).Max();


 if (!DBNull.Value.Equals(i.AddressID))
                {
                    BKDataSet.AddressRow ar = mf.DS.Address.FindByID(Convert.ToInt32(i.AddressID));
                    combArea.Text = ar.Area;
                    combTwon.Text = ar.Town;
                }

--------------------------------
���ݽ��鵥λ �еĵ�λ����ˡ���Ҫ�����ҵ���