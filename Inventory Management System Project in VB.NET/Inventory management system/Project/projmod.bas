Attribute VB_Name = "Module1"
Public con As New ADODB.Connection
Public indrs As New ADODB.Recordset
'Public inddtlrs As New ADODB.Recordset
Public itemrs As New ADODB.Recordset
Public venderrs As New ADODB.Recordset
Public enqrs As New ADODB.Recordset
Public qutnrs As New ADODB.Recordset
Public pors As New ADODB.Recordset
Public recptrs As New ADODB.Recordset
Public isuers As New ADODB.Recordset
Public retunrs As New ADODB.Recordset
Public stockrs As New ADODB.Recordset
Public Sub main()
con.Open "inventory", "scott", "tiger"
indrs.Open "select * from ind_hdr order by indantno", con, adOpenKeyset, adLockOptimistic
retunrs.Open "select * from retun_hdr order by retno", con, adOpenKeyset, adLockOptimistic
itemrs.Open "select * from item order by itemcode", con, adOpenKeyset, adLockOptimistic
venderrs.Open "select * from vendor order by vno", con, adOpenKeyset, adLockOptimistic
enqrs.Open "select * from enq_hdr order by enqno", con, adOpenKeyset, adLockOptimistic
qutnrs.Open "select * from qutn_hdr order by qutno", con, adOpenKeyset, adLockOptimistic
pors.Open "select * from po_hdr order by pono", con, adOpenKeyset, adLockOptimistic
recptrs.Open "select * from rept_hdr order by rp_no", con, adOpenKeyset, adLockOptimistic
isuers.Open "select * from isue_hdr order by isuno", con, adOpenKeyset, adLockOptimistic
stockrs.Open "select * from stock order by sdate", con, adOpenKeyset, adLockOptimistic
Form13.Show
End Sub
Sub closing()
indrs.Close
retunrs.Close
itemrs.Close
venderrs.Close
enqrs.Close
qutnrs.Close
pors.Close
recptrs.Close
isuers.Close
stockrs.Close
End Sub
