select a.Acc_no as ACCCNO,a.Acc_hl_Name as [Account_Holder_Name],
a.Balance,
a.Ref_Acc_no as [Ref_Acc_No],
r.Acc_hl_Name [Name of Refer]
from BANK_DB a left join BANK_DB r
on a.Ref_Acc_No=r.Acc_No