3.1 task
 
## 1
لما يكون عندنا constructor في اكتر من 20 parameter بيخلي استخدام الكلاس صعب في call site علشا صعب نفتكر وظيفه كل قيمه بمكانها 
خصوصا لما يكون عندنا حاجه من نفس ال data type وكمان لو ضيفنا property جديده اختاريه هنحتاج نعدل ال constructor والاماكن اللي بتcall
وده بيخلي الكود صعب في  debugging , maintenance


## 2
 المشكله هنا مش انه ال constructor طويل 
الفكره كده الكلاس عندي مجموعات مختلفة من البيانات
فكده الكلاس بقا كبير وعنده بيانات مش related ببعض


-------------------------------
3.3 task

1- Composed Builder or Single Big Builder?
The Composed Builder is better because each builder is responsible for one part instead of one builder handling everything

-Single Responsibility:
AddressBuilderis responsible for building and validating the Address and OrderBuilder is responsible for the Order and Payment an InvoiceBuilder is responsible for combining all parts and creating the final Invoice

-Independent Validation:
AddressBuildercan check that Street City State ZipCode and Country are provided without InvoiceBuilder knowing the Address validation rules

-Reuse:
The same AddressBuilder can be used for both Billing Address and Shipping Address This avoids repeating the same Address building and validation code

Readability at the Call Site:

•In Task 3.2 InvoiceBuilder handled Customer Addresses Order Payment and Amounts

•In Task 3.3 each part is built separately and then combined. This makes the code easier to read and understand

