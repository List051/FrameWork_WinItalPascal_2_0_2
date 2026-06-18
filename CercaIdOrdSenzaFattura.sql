SELECT Ordini.IDOrd, Ordini.IDCliOrd, Ordini.Mat
FROM     Ordini LEFT OUTER JOIN
                  Fattura ON Ordini.IDOrd = Fattura.IDOrd
WHERE  (Fattura.IDOrd IS NULL)