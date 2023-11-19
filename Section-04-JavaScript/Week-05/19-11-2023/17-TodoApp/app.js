"use strict";
//elemetlere erişelim. ve sürekli erişmemiz gerektiği için kolay olsun diye değişkene atadık.
const textTaskDescription = document.getElementById("text-task-description");
const btnAddTask = document.getElementById("btn-add-task");
const taskList = document.getElementById("task-list");
const btnClearAll = document.getElementById("btn-clear-all");
const filters = document.querySelectorAll("#filters span");


let isEditMode = false;// eğer bu değişken false ise yeni kayıt modundayız. true ise düzenlme modundayız.
let editedTaskId;// o anda hangi görev düzenleniyor ise uygulama boyunca geçerli olacak şekilde o görevin idsini tutmaya yarar.
let filterMode = "all";

let taskListArray = [];

// bir değişkene herhangi bir event eklemek istediğimizde addEventListener  fonk. kullanırız.

//btnAddTask elementine click yapıldığında çalışacak fonksiyonun adı adddTasktir. click yapıldığında çalıştır dediğimiz  için yanına parantez aç-kapa yapmadık. literatürde bunlara callback denir.
btnAddTask.addEventListener("click", addTask);

//btnClearAll elementine click yapıldığında çalışacak fonksiyonun adı clearAlldır.
btnClearAll.addEventListener("click", clearAll);

//yeni görev ekleyen fonksiyon
function addTask(event) {

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
        displayTasks(filterMode);
        setTasks();
    } else {
        alert("Lütfen görev açıklamasını boş bırakmayınız.");
    }
    textTaskDescription.value = ""; //veri girişi yaptıktan sonra kutunun içinin temizlenmesini sağlıyor.
    textTaskDescription.focus(); //imlecin orada kalmasını sağlıyor.

}

//bu function, her ihtiyaç duyulduğunda tüm görevleri yeniden okuyup ekranda göstermek için kullanılacak.
function displayTasks(filter) {
    taskList.innerHTML = "";
    if (taskListArray.length == 0) {
        taskList.innerHTML = `  <div class="alert alert-warning mb-0">Tanımlı görev bulunmamaktadır</div>`;

    } else {

        for (const task of taskListArray) {
            if (filter == "all" || filter == task.status) {
                let completed = task.status == "completed" ? "checked" : "";
                let taskLi = `

                <li class="task list-group-item" id="${task.id}">

                    <div class="form-check d-flex justify-content-between align-items-center">
                        <input onclick="updateStatus(this);" type="checkbox" id="${task.id}" class="form-check-input" ${completed}>
                        <div class="input-group">
                            <input id="${task.id}" class="form-control ${completed} " type="text" value="${task.taskDescription}"
                                disabled/>
                            <button onclick="editTask(this)"; id="${task.id}" class="btn btn-warning"><i
                                    class="fa-solid fa-pen-to-square"></i></button>
                            <button onclick="deleteTask(this)"; id="${task.id}" class="btn btn-danger"><i class="fa-solid fa-trash"></i></button>

                        </div>
                    </div>
                </li>

`;

                taskList.insertAdjacentHTML("beforeend", taskLi);
            };

        };

    };
};

//Task update( tamamlandı/devam ediyor) işlemini yapan fonksiyon
//checkboxa tikleyince verinin üstünü çizme
function updateStatus(activeTask) {
    let newStatus = activeTask.checked == true ? "completed" : "pending";
    for (const task of taskListArray) {
        if (activeTask.id == task.id) {
            task.status = newStatus;
            break;
        }

    }
    setTasks();
    displayTasks(filterMode);
}

//ilgili görevin düzenlenmesini yapar.
function editTask(clickedButton) {

    //Araştırma Ödevi: bir texte odaklandığımızda içindeki metnin sonuna yada seçili bir halde odaklanmanın bir yolu var mı varsa nasıl?
    editedTaskId = clickedButton.id;
    let editedTask = clickedButton.previousElementSibling;
    let checked;
    for (const task of taskListArray) {
        if (task.id == editedTaskId) {
            checked = task.status;
        };
    }

    //İseditmode false ise  
    if (!isEditMode) {
        editedTask.removeAttribute("disabled");
        if (checked = "completed") editedTask.classList.remove("checked");
        clickedButton.classList.remove("btn-warning");
        clickedButton.classList.add("btn-info");
        // clickedButton.firstElementChild.classList.remove("fa-pen-to-square");
        // clickedButton.firstElementChild.classList.remove("fa-solid");
        // clickedButton.firstElementChild.classList.add("fa-circle-check");
        // clickedButton.firstElementChild.classList.add("fa-regular");
        editedTask.focus();
        //yada;
        clickedButton.innerHTML = `<i class="fa-regular fa-circle-check"></i>`;
        isEditMode = true;
    }
    else {
        editedTask.setAttribute("disabled", "disabled");
        if (checked == "completed") editedTask.classList.add("checked");
        clickedButton.classList.remove("btn-info");
        clickedButton.classList.add("btn-warning");
        clickedButton.innerHTML = `<i class="fa-solid fa-pen-to-square"></i>`;
        for (const task of taskListArray) {
            if (editedTaskId == task.id) {
                task.taskDescription = editedTask.value;
                break;
            }
        }
        isEditMode = false;
        setTasks();
        displayTasks(filterMode);

    }



}
//ilgili görevin silinmesini sağlar.
function deleteTask(clickedButton) {
    let deletedTaskId = clickedButton.id;
    let deletedTask = taskListArray.filter(function (task) {
        if (deletedTaskId == task.id) return true;

    });
    let deletedTaskDescription = deletedTask[0].taskDescription;
    let answer = confirm(`'${deletedTaskDescription}' görevi silinecektir.`);
    if (answer) {
        let index = taskListArray.indexOf(deletedTask[0]);// sileceğim kaydın indexi
        taskListArray.splice(index, 1);
        setTasks();
        displayTasks(filterMode);
        alert("Silme işlemi başarıyla tamamlanmıştır");
    }
}

//tüm görevleri siler.
function clearAll() {
    let answer = confirm("Tüm görevler silinecektir.");
    if (answer) {
        // aşağıdakine alternatif;  taskListArray=[];
        taskListArray.splice(0);
        setTasks();
        displayTasks(filterMode);

    }
};

//filters içindeki spanlara click eventlerini atar.
function assignSpansEvents() {
    for (const span of filters) {
        span.addEventListener("click", function () {
            let activeSpan = document.querySelector("span.active");
            activeSpan.classList.remove("active");
            span.classList.add("active");
            filterMode = span.id;
            displayTasks(filterMode);
        });
    };
};

//localstorageteki datamızı okuyup dizinin içine aktaracak.
function getTasks() {
    // Tasklerimiz localstoragete TaskList adında bir key in içinde olacak.

    let TaskListItem = localStorage.getItem("TaskList")
    if (TaskListItem != null) {
        taskListArray = JSON.parse(TaskListItem);
    };
    console.log(TaskListItem, typeof TaskListItem);
};

function setTasks() {
    localStorage.setItem("TaskList", JSON.stringify(taskListArray));
};


getTasks();
displayTasks(filterMode);
assignSpansEvents();

//ARAŞTIRMA ÖDEVİ: Görev Adına tıkladığımızda da completed ya da pending şeklinde status değişimi olmasını nasıl sağlarız?