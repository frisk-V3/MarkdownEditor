import { marked } from 'marked';

const editor = document.getElementById('editor') as HTMLTextAreaElement;
const preview = document.getElementById('preview') as HTMLDivElement;

const render = async () => {
    preview.innerHTML = await marked.parse(editor.value);
};

editor.addEventListener('input', render);
render(); // 初回表示
