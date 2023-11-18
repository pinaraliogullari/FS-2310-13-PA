"use strict";
//elemetlere erişelim. ve sürekli erişmemiz gerektiği için kolay olsun diye değişkene atadık.
const textTaskDescription = document.getElementById("text-task-description");
const btnAddTask = document.getElementById("btn-add-task");
const taskList = document.getElementById("task-list");
let taskListArray = [
    { id: 1, taskDescription: "Netflix izle", status: "completed" },
    { id: 2, taskDescription: "Pilavı unutma", status: "pending" },
    { id: 3, taskDescription: "Yemek ye", status: "pending" },
    { id: 4, taskDescription: "Pazar günü için toplantı planla", status: "completed" },
    { id: 5, taskDescription: "Konu tekrarı", status: "pending" }


];


// bir değişkene herhangi bir event eklemek istediğimizde addEventListener  fonk. kullanırız.

btnAddTask.addEventListener("click", function (event) { //isimsiz fonk:anonim fonk.

    event.preventDefault(); // ilgili oalyın d efault davranışlarını iptal ediyor. örn:submit typte butona tıkladıktan sonra veri siliniyor. bu default davranışı preventdefault ile yok ettik.
    let value = textTaskDescription.value.trim();
    if (value != "") {
        let id = taskListArray.length == 0 ? 1 : taskListArray[taskListArray.length - 1].id + 1;
        taskListArray.push(
            {
                "id": id,
                "taskDescription": value,
                "status": "pending"
            }
        );
        // console.log(taskListArray);
    } else {
        alert("Lütfen görev açıklamasını boş bırakmayınız.");
    }
    textTaskDescription.value = ""; //veri girişi yaptıktan sonra kutunun içinin temizlenmesini sağlıyor.
    textTaskDescription.focus(); //imlecin orada kalmasını sağlıyor.

});

function displayTasks() {
    //bu function, her ihtiyaç duyulduğunda tüm görevleri yeniden okuyup ekranda göstermek için kullanılacak.
    taskList.innerHTML = "";
    if (taskListArray.length == 0) {
        taskList.innerHTML = `  <div class="alert alert-warning mb-0">Tanımlı görev bulunmamaktadır</div>`;

    } else {

    }
}

displayTasks();