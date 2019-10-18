
var myEditor;
ClassicEditor
    .create( document.querySelector( '#editor' ), {
        toolbar: ['heading', '|', 'bold', 'italic', 'link', 'bulletedList', 'numberedList', 'blockQuote', "imageUpload"],

        heading: {
            options: [
                { model: 'paragraph', title: 'Paragraph', class: 'ck-heading_paragraph' },
                { model: 'heading1', view: 'h1', title: 'Heading 1', class: 'ck-heading_heading1' },
                { model: 'heading2', view: 'h2', title: 'Heading 2', class: 'ck-heading_heading2' }
            ]
        },
    } )
    .then( editor => {
        console.log( 'Editor was initialized', editor );
        myEditor = editor;
    } )
    .catch( error => {
        console.error( error );
    } );
document.querySelector( '#submit' ).addEventListener( 'click', () => {
    var myurl="indexAPI.php";
    $.ajax({
        url:myurl,
        type:"POST",
        data: {
            "request":"post",
            "title":$("#title").val(),
            "content":myEditor.getData(),
            "content_without_tags":removeHtmlTags(myEditor.getData())
        }
    }).done(
        function (APIData) {
            if(APIData.result==="true")
            {
                console.log(APIData);
                window.history.go(-1);
            }
            else
            {
                console.log(APIData);
                alert(APIData.warning);
            }
        }
    )
})
function removeHtmlTags(str)
{
    str = str.replace(/<\/?[^>]*>/g, '');
    return str;
}

$(document).ready(function(){
})

/*class UploadAdapter {
    constructor(loader, url) {
        this.loader = loader;
    }
    upload() {
        return new Promise((resolve, reject) => {
            const data = new FormData();
            data.append('upload', this.loader.file);
            data.append('allowSize', 10);//允许图片上传的大小/兆
            $.ajax({
                url: '/article/image',
                type: 'POST',
                data: data,
                dataType: 'json', // 期望返回的数据类型
                processData: false,
                contentType: false, // 避免jQuery添加对应的内容类型，否则flask中无法获取到文件
                success: function (data) {
                    console.log("success, data is:", data)
                    if (data.res) {
                        resolve({ default: data.url });  // 将获取到的图片url返回给编辑器
                    } else {  reject(data.msg);  }
                },
                complete: function (data) {
                    console.log("complete, data is:", data)
                }
            });
        })
    }
    abort() {
        console.log("abort")
    }
}*/