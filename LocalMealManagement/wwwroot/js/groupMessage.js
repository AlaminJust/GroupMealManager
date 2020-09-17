var groupMessage = {


    addMessage: function (message, groupId) {
        event.preventDefault();
        var GroupMessageViewModel = {
            Message: message,
            GroupId: groupId,
        }
        $.ajax({
            type: "POST",
            url: "/GroupMessage/AddMessage?groupId="+groupId,
            dataType: "json",
            data: { model: GroupMessageViewModel },
            success: function (data) {
                console.log('Hello test', data);
                window.location.reload(1);
            },
            error: function (response) {
                console.log('Failed');
            }
        })
    },

    messageSubmit: function (groupId) {
        var message = $('#messagess').val();
        console.log(message, groupId);
        if (message.length) {
            this.addMessage(message, groupId);
        }
    }
}

