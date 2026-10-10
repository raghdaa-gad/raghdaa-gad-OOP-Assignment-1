## Task 1.1 --Critique

Problem?
↓
Why is it a problem?
↓
What could go wrong?
-----------------------------------------------
1-Global state:

Problem ? Global state
↓
Why is it a problem ? اي حد يقدر يوصلهم ويعدل عليهم,global variables البيانات متخزنة ك
↓
What could go wrong ?
اي فانكشن ممكن تعدل بشكل غير مقصود ولما البرنامج يكبر هيبقي صعب نعرف مين المسؤول عن التغير والمشكلة حصلت فين بظبط

---------------------------------------------
2-Parallel Arrays / Index-Based Data :

Problem?
Parallel Arrays / Index-Based Data 
↓
Why is it a problem?
ال relationبين البيانات معتمدة علي رقم ال index بدل ماتكون objects مرتبطة ببعض بشكل اوضح
↓
What could go wrong?
لو ال indexes اتلخبطت او البيانات اتغير ترتيبها
ممكن ال order يشاور علي customer بلغلط فكده ممكن نطلع بيانات غلط و حسابات 

فبدل مانوصل للحاجه كده order.customer
بنوصل كده Order → index → array → Customer

--------------------------------------------
3-Functions Have Multiple Responsibilities

Problem?
Functions Have Multiple Responsibilities
↓
Why is it a problem?
مثلا عندنا فانكشن addLineToOrder بتعمل كذا حاجه في نفس الوقت والمفروض الفانكشن تعمل one action
ال function الواحدة بقيت مسؤولة عن كذا حاجه ومع الوقت ال system بيكبر فهيبقي صعب ن handle او ن edit اي مشكله فيها بعد كده
↓
What could go wrong?
لو غيرنا جزء من ال logic ممكن ناثر بالغلط علي جزء تاني موجود في نفس الفانكشن ومع تطور البرنامج هتبقي ال function صعبه في ال debugging and maintenance

---------------------------------------------
4-Data and Behavior Are Separated

Problem?
Data and Behavior Are Separated
↓
Why is it a problem?
ال data , logic مش متجمعين في مكان واحد ف مفيش object واضح مسؤول عن نفسه 
↓
What could go wrong?
التعديل بعد كده هيبقي صعب

-------------------------------------------

