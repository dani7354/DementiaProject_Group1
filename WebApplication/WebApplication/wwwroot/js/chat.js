const messageContainer = document.querySelector('.js-messageContainer')
const inputForm = document.querySelector('.js-inputForm')
const inputField = document.querySelector('.js-inputField')
const dots = document.querySelector('.js-dots')



function ShowUserMessage() {
    let userMessage = inputField.value
    let messageDiv = document.createElement('div')
    let messageBubble = `<span class="Chat-bubble">${userMessage}</span>`
    messageDiv.classList.add('Chat-message', 'Chat-message--user')
    messageDiv.innerHTML += messageBubble;
    messageContainer.insertBefore(messageDiv, dots)
    messageContainer.classList.add('Chat-messages--typing')

}
function ShowReply(reply) {
    let messageDiv = document.createElement('div')
    let messageBubble = `<span class="Chat-bubble">${reply}</span>`
    messageDiv.classList.add('Chat-message', 'Chat-message--bot')
    messageDiv.innerHTML += messageBubble;
    messageContainer.insertBefore(messageDiv, dots)
}
inputForm.addEventListener('submit', (e) => {
    ShowUserMessage();
    // Send user userMessage to the controller and receive response.
    $.ajax({
        type: "POST",
        url: '/message/reply',
        data: {
            message: $(".js-inputField").val()
        },
        dataType: 'json',
        success: function (response) {
            ShowReply(response.reply);
        },
    });

    inputForm.reset();
    e.preventDefault();

});